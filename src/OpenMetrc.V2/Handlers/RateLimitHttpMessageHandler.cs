using System.Collections.Concurrent;
using System.Web;

// ReSharper disable once CheckNamespace
namespace OpenMetrc;

class RateLimitHttpMessageHandler : DelegatingHandler
{
    static readonly ConcurrentDictionary<string, SemaphoreSlim> ConcurrentCallsPerSecondPerFacilitySemaphore = new();
    static readonly ConcurrentDictionary<string, SemaphoreSlim> ConcurrentCallsPerSecondPerIntegratorSemaphore = new();
    static readonly ConcurrentDictionary<string, AsyncRateLimitedSemaphore> CallsPerSecondPerFacilitySemaphore = new();

    static readonly ConcurrentDictionary<string, AsyncRateLimitedSemaphore>
        CallsPerSecondPerIntegratorSemaphore = new();

    public int CallsPerSecondPerFacility = 50;
    public int CallsPerSecondPerIntegrator = 150;
    public int ConcurrentCallsPerSecondPerFacility = 10;
    public int ConcurrentCallsPerSecondPerIntegrator = 30;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        //var now = DateTimeOffset.Now.ToUnixTimeSeconds();
        if (request.RequestUri == null) return await base.SendAsync(request, cancellationToken);

        var integrator = request.RequestUri.Host;
        var facility = HttpUtility.ParseQueryString(request.RequestUri.Query).Get("licenseNumber") ?? integrator;
        if (facility == "NA")
            throw new ArgumentException($@"The provided license is invalid: {request.RequestUri.AbsoluteUri}");

        ConcurrentCallsPerSecondPerFacilitySemaphore.TryAdd(facility,
            new SemaphoreSlim(ConcurrentCallsPerSecondPerFacility));
        CallsPerSecondPerFacilitySemaphore.TryAdd(facility,
            new AsyncRateLimitedSemaphore(CallsPerSecondPerFacility, TimeSpan.FromSeconds(1)));

        ConcurrentCallsPerSecondPerIntegratorSemaphore.TryAdd(integrator,
            new SemaphoreSlim(ConcurrentCallsPerSecondPerIntegrator));
        CallsPerSecondPerIntegratorSemaphore.TryAdd(integrator,
            new AsyncRateLimitedSemaphore(CallsPerSecondPerIntegrator, TimeSpan.FromSeconds(1)));

        await CallsPerSecondPerFacilitySemaphore[facility].WaitAsync();
        await CallsPerSecondPerIntegratorSemaphore[integrator].WaitAsync();

        await ConcurrentCallsPerSecondPerFacilitySemaphore[facility].WaitAsync(cancellationToken);
        await ConcurrentCallsPerSecondPerIntegratorSemaphore[integrator].WaitAsync(cancellationToken);
        var result = await base.SendAsync(request, cancellationToken);
        ConcurrentCallsPerSecondPerFacilitySemaphore[facility].Release();
        ConcurrentCallsPerSecondPerIntegratorSemaphore[integrator].Release();

        return result;
    }

    class AsyncRateLimitedSemaphore
    {
        readonly int _maxCount;

        readonly object _resetTimeLock = new();
        readonly TimeSpan _resetTimeSpan;

        readonly SemaphoreSlim _semaphore;
        long _nextResetTimeTicks;

        public AsyncRateLimitedSemaphore(int maxCount, TimeSpan resetTimeSpan)
        {
            _maxCount = maxCount;
            _resetTimeSpan = resetTimeSpan;

            _semaphore = new SemaphoreSlim(maxCount, maxCount);
            _nextResetTimeTicks = (DateTimeOffset.UtcNow + _resetTimeSpan).UtcTicks;
        }

        void TryResetSemaphore()
        {
            // quick exit if before the reset time, no need to lock
            if (!(DateTimeOffset.UtcNow.UtcTicks > Interlocked.Read(ref _nextResetTimeTicks))) return;

            // take a lock so only one reset can happen per period
            lock (_resetTimeLock)
            {
                var currentTime = DateTimeOffset.UtcNow;
                // need to check again in case a reset has already happened in this period
                if (currentTime.UtcTicks > Interlocked.Read(ref _nextResetTimeTicks))
                {
                    _semaphore.Release(_maxCount - _semaphore.CurrentCount);

                    var newResetTimeTicks = (currentTime + _resetTimeSpan).UtcTicks;
                    Interlocked.Exchange(ref _nextResetTimeTicks, newResetTimeTicks);
                }
            }
        }

        public async Task WaitAsync()
        {
            // attempt a reset in case it's been some time since the last wait
            TryResetSemaphore();

            var semaphoreTask = _semaphore.WaitAsync();

            // if there are no slots, need to keep trying to reset until one opens up
            while (!semaphoreTask.IsCompleted)
            {
                var ticks = Interlocked.Read(ref _nextResetTimeTicks);
                var nextResetTime = new DateTimeOffset(new DateTime(ticks, DateTimeKind.Utc));
                var delayTime = nextResetTime - DateTimeOffset.UtcNow;

                // delay until the next reset period
                // can't delay a negative time so if it's already passed just continue with a completed task
                var delayTask = delayTime >= TimeSpan.Zero ? Task.Delay(delayTime) : Task.CompletedTask;

                await Task.WhenAny(semaphoreTask, delayTask);

                TryResetSemaphore();
            }
        }
    }
}