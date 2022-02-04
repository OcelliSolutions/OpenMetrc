using System.Collections.Concurrent;
using System.Web;

// ReSharper disable once CheckNamespace
namespace OpenMetrc;

class RateLimitHttpMessageHandler : DelegatingHandler
{
    const int FacilityLimitCount = 50;
    const int IntegratorLimitCount = 150;
    static readonly ConcurrentDictionary<string, SemaphoreSlim> _facilitySemaphore = new();
    static readonly ConcurrentDictionary<string, SemaphoreSlim> _integratorSemaphore = new();
    static readonly ConcurrentDictionary<string, List<DateTimeOffset>> _facilityCallLog = new();
    static readonly ConcurrentDictionary<string, List<DateTimeOffset>> _integratorCallLog = new();
    readonly TimeSpan _limitTime = TimeSpan.FromSeconds(1);

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var now = DateTimeOffset.UtcNow;
        if (request.RequestUri == null) return await base.SendAsync(request, cancellationToken);

        var integrator = request.RequestUri.Host;
        var facility = HttpUtility.ParseQueryString(request.RequestUri.Query).Get("licenseNumber") ?? integrator;

        _facilitySemaphore.TryAdd(facility, new SemaphoreSlim(10));
        _facilityCallLog.TryAdd(facility, new List<DateTimeOffset>());

        _integratorSemaphore.TryAdd(integrator, new SemaphoreSlim(30));
        _integratorCallLog.TryAdd(integrator, new List<DateTimeOffset>());


        lock (_facilityCallLog)
        {
            lock (_integratorCallLog)
            {
                _facilityCallLog[facility].Add(now);
                while (_facilityCallLog[facility].Count > FacilityLimitCount)
                    _facilityCallLog[facility].RemoveAt(0);

                _integratorCallLog[integrator].Add(now);
                while (_integratorCallLog[integrator].Count > IntegratorLimitCount)
                    _integratorCallLog[integrator].RemoveAt(0);
            }
        }

        await LimitDelay(facility, integrator, now);
        var result = new HttpResponseMessage();
        try
        {
            await _facilitySemaphore[facility].WaitAsync(cancellationToken);
            await _integratorSemaphore[integrator].WaitAsync(cancellationToken);
            result = await base.SendAsync(request, cancellationToken);
            _facilitySemaphore[facility].Release();
            _integratorSemaphore[integrator].Release();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return result;
    }

    async Task LimitDelay(string facility, string integrator, DateTimeOffset now)
    {
        if (_facilityCallLog.Count < FacilityLimitCount && _integratorCallLog.Count < IntegratorLimitCount) return;

        var limit = now.Add(-_limitTime);

        var facilityLastCall = DateTimeOffset.MinValue;
        var facilityShouldLock = false;
        var integratorLastCall = DateTimeOffset.MinValue;
        var integratorShouldLock = false;

        lock (_facilityCallLog)
        {
            lock (_integratorCallLog)
            {
                facilityLastCall = _facilityCallLog[facility].FirstOrDefault();
                facilityShouldLock = _facilityCallLog[facility].Count(x => x >= limit) >= FacilityLimitCount;

                integratorLastCall = _integratorCallLog[integrator].FirstOrDefault();
                integratorShouldLock = _integratorCallLog[integrator].Count(x => x >= limit) >= IntegratorLimitCount;
            }
        }

        var delayTime = facilityShouldLock && facilityLastCall > DateTimeOffset.MinValue ||
                        integratorShouldLock && integratorLastCall > DateTimeOffset.MinValue
            ? limit - facilityLastCall
            : TimeSpan.Zero;

        if (delayTime > TimeSpan.Zero)
            await Task.Delay(delayTime);
    }
}