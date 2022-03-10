using System.Collections.Concurrent;
using System.Web;

// ReSharper disable once CheckNamespace
namespace OpenMetrc;

class RateLimitHttpMessageHandler : DelegatingHandler
{
    static readonly ConcurrentDictionary<string, SemaphoreSlim> ConcurrentCallsPerSecondPerFacilitySemaphore = new();
    static readonly ConcurrentDictionary<string, SemaphoreSlim> ConcurrentCallsPerSecondPerIntegratorSemaphore = new();
    //static readonly ConcurrentDictionary<string, List<DateTimeOffset>> CallsPerSecondPerFacilitySemaphore = new();
    //static readonly ConcurrentDictionary<string, List<DateTimeOffset>> CallsPerSecondPerIntegratorSemaphore = new();
    static readonly ConcurrentDictionary<string, AsyncRateLimitedSemaphore> CallsPerSecondPerFacilitySemaphore = new();
    static readonly ConcurrentDictionary<string, AsyncRateLimitedSemaphore> CallsPerSecondPerIntegratorSemaphore = new();

    readonly TimeSpan _limitTime = TimeSpan.FromSeconds(1);
    public int CallsPerSecondPerFacility = 50;
    public int CallsPerSecondPerIntegrator = 150;
    public int ConcurrentCallsPerSecondPerFacility = 10;
    public int ConcurrentCallsPerSecondPerIntegrator = 30;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var now = DateTimeOffset.Now.ToUnixTimeSeconds();
        if (request.RequestUri == null) return await base.SendAsync(request, cancellationToken);

        var integrator = request.RequestUri.Host;
        var facility = HttpUtility.ParseQueryString(request.RequestUri.Query).Get("licenseNumber") ?? integrator;
        if (facility == "NA")
            Console.WriteLine($@"{request.RequestUri.AbsoluteUri}");

        ConcurrentCallsPerSecondPerFacilitySemaphore.TryAdd(facility, new SemaphoreSlim(ConcurrentCallsPerSecondPerFacility));
        CallsPerSecondPerFacilitySemaphore.TryAdd(facility, new AsyncRateLimitedSemaphore(CallsPerSecondPerFacility, TimeSpan.FromSeconds(1)));

        ConcurrentCallsPerSecondPerIntegratorSemaphore.TryAdd(integrator, new SemaphoreSlim(ConcurrentCallsPerSecondPerIntegrator));
        CallsPerSecondPerIntegratorSemaphore.TryAdd(integrator, new AsyncRateLimitedSemaphore(CallsPerSecondPerIntegrator, TimeSpan.FromSeconds(1)));
        
        var result = new HttpResponseMessage();
        try
        {
            await CallsPerSecondPerFacilitySemaphore[facility].WaitAsync();
            await CallsPerSecondPerIntegratorSemaphore[integrator].WaitAsync();

            await ConcurrentCallsPerSecondPerFacilitySemaphore[facility].WaitAsync(cancellationToken);
            await ConcurrentCallsPerSecondPerIntegratorSemaphore[integrator].WaitAsync(cancellationToken);
            //Console.WriteLine($@"{facility} {now}");
            result = await base.SendAsync(request, cancellationToken);
            ConcurrentCallsPerSecondPerFacilitySemaphore[facility].Release();
            ConcurrentCallsPerSecondPerIntegratorSemaphore[integrator].Release();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return result;
    }
    /*
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var now = DateTimeOffset.UtcNow;
        if (request.RequestUri == null) return await base.SendAsync(request, cancellationToken);

        var integrator = request.RequestUri.Host;
        var facility = HttpUtility.ParseQueryString(request.RequestUri.Query).Get("licenseNumber") ?? integrator;
        if(facility == "NA")
            Console.WriteLine($@"{request.RequestUri.AbsoluteUri}");

        ConcurrentCallsPerSecondPerFacilitySemaphore.TryAdd(facility, new SemaphoreSlim(5));
        lock (CallsPerSecondPerFacilitySemaphore)
        {
            CallsPerSecondPerFacilitySemaphore.TryAdd(facility, new List<DateTimeOffset>());
        }

        ConcurrentCallsPerSecondPerIntegratorSemaphore.TryAdd(integrator, new SemaphoreSlim(15));
        lock (CallsPerSecondPerIntegratorSemaphore)
        {
            CallsPerSecondPerIntegratorSemaphore.TryAdd(integrator, new List<DateTimeOffset>());
        }

        
        lock (CallsPerSecondPerFacilitySemaphore)
        {
            lock (CallsPerSecondPerIntegratorSemaphore)
            {
                CallsPerSecondPerFacilitySemaphore[facility].Add(now);
                while (CallsPerSecondPerFacilitySemaphore[facility].Count > CallsPerSecondPerFacility)
                    CallsPerSecondPerFacilitySemaphore[facility].RemoveAt(0);

                CallsPerSecondPerIntegratorSemaphore[integrator].Add(now);
                while (CallsPerSecondPerIntegratorSemaphore[integrator].Count > CallsPerSecondPerIntegrator)
                    CallsPerSecondPerIntegratorSemaphore[integrator].RemoveAt(0);
            }
        }
        

        await LimitDelay(facility, integrator, now);
        var result = new HttpResponseMessage();
        try
        {
            await ConcurrentCallsPerSecondPerFacilitySemaphore[facility].WaitAsync(cancellationToken);
            await ConcurrentCallsPerSecondPerIntegratorSemaphore[integrator].WaitAsync(cancellationToken);
            Console.WriteLine($@"facility: {facility} - {now}");
            result = await base.SendAsync(request, cancellationToken);
            ConcurrentCallsPerSecondPerFacilitySemaphore[facility].Release();
            ConcurrentCallsPerSecondPerIntegratorSemaphore[integrator].Release();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return result;
    }
    async Task LimitDelay(string facility, string integrator, DateTimeOffset now)
    {
        lock (CallsPerSecondPerFacilitySemaphore)
        {
            if (CallsPerSecondPerFacilitySemaphore.Count < CallsPerSecondPerFacility && CallsPerSecondPerIntegratorSemaphore.Count < CallsPerSecondPerIntegrator) return;
        }

        var limit = now.Add(-_limitTime);

        DateTimeOffset facilityLastCall;
        bool facilityShouldLock;
        DateTimeOffset integratorLastCall;
        bool integratorShouldLock;

        lock (CallsPerSecondPerFacilitySemaphore)
        {
            lock (CallsPerSecondPerIntegratorSemaphore)
            {
                facilityLastCall = CallsPerSecondPerFacilitySemaphore[facility].FirstOrDefault();
                facilityShouldLock = CallsPerSecondPerFacilitySemaphore[facility].Count(x => x >= limit) >= CallsPerSecondPerFacility;

                integratorLastCall = CallsPerSecondPerIntegratorSemaphore[integrator].FirstOrDefault();
                integratorShouldLock = CallsPerSecondPerIntegratorSemaphore[integrator].Count(x => x >= limit) >= CallsPerSecondPerIntegrator;
            }
        }

        var delayTime = facilityShouldLock && facilityLastCall > DateTimeOffset.MinValue ||
                        integratorShouldLock && integratorLastCall > DateTimeOffset.MinValue
            ? limit - facilityLastCall
            : TimeSpan.Zero;

        if (delayTime > TimeSpan.Zero)
            await Task.Delay(delayTime);
    }
    */

    class AsyncRateLimitedSemaphore
    {
        private readonly int maxCount;
        private readonly TimeSpan resetTimeSpan;

        private readonly SemaphoreSlim semaphore;
        private long nextResetTimeTicks;

        private readonly object resetTimeLock = new();

        public AsyncRateLimitedSemaphore(int maxCount, TimeSpan resetTimeSpan)
        {
            this.maxCount = maxCount;
            this.resetTimeSpan = resetTimeSpan;

            this.semaphore = new SemaphoreSlim(maxCount, maxCount);
            this.nextResetTimeTicks = (DateTimeOffset.UtcNow + this.resetTimeSpan).UtcTicks;
        }

        private void TryResetSemaphore()
        {
            // quick exit if before the reset time, no need to lock
            if (!(DateTimeOffset.UtcNow.UtcTicks > Interlocked.Read(ref this.nextResetTimeTicks)))
            {
                return;
            }

            // take a lock so only one reset can happen per period
            lock (this.resetTimeLock)
            {
                var currentTime = DateTimeOffset.UtcNow;
                // need to check again in case a reset has already happened in this period
                if (currentTime.UtcTicks > Interlocked.Read(ref this.nextResetTimeTicks))
                {
                    this.semaphore.Release(this.maxCount - this.semaphore.CurrentCount);

                    var newResetTimeTicks = (currentTime + this.resetTimeSpan).UtcTicks;
                    Interlocked.Exchange(ref this.nextResetTimeTicks, newResetTimeTicks);
                }
            }
        }

        public async Task WaitAsync()
        {
            // attempt a reset in case it's been some time since the last wait
            TryResetSemaphore();

            var semaphoreTask = this.semaphore.WaitAsync();

            // if there are no slots, need to keep trying to reset until one opens up
            while (!semaphoreTask.IsCompleted)
            {
                var ticks = Interlocked.Read(ref this.nextResetTimeTicks);
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