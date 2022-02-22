using System.Collections.Concurrent;
using System.Web;

// ReSharper disable once CheckNamespace
namespace OpenMetrc;

class RateLimitHttpMessageHandler : DelegatingHandler
{
    static readonly ConcurrentDictionary<string, SemaphoreSlim> FacilitySemaphore = new();
    static readonly ConcurrentDictionary<string, SemaphoreSlim> IntegratorSemaphore = new();
    static readonly ConcurrentDictionary<string, List<DateTimeOffset>> FacilityCallLog = new();
    static readonly ConcurrentDictionary<string, List<DateTimeOffset>> IntegratorCallLog = new();
    readonly TimeSpan _limitTime = TimeSpan.FromSeconds(1);
    public int FacilityLimitCount = 50;
    public int IntegratorLimitCount = 150;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var now = DateTimeOffset.UtcNow;
        if (request.RequestUri == null) return await base.SendAsync(request, cancellationToken);

        var integrator = request.RequestUri.Host;
        var facility = HttpUtility.ParseQueryString(request.RequestUri.Query).Get("licenseNumber") ?? integrator;

        FacilitySemaphore.TryAdd(facility, new SemaphoreSlim(10));
        lock (FacilityCallLog)
        {
            FacilityCallLog.TryAdd(facility, new List<DateTimeOffset>());
        }

        IntegratorSemaphore.TryAdd(integrator, new SemaphoreSlim(30));
        lock (IntegratorCallLog)
        {
            IntegratorCallLog.TryAdd(integrator, new List<DateTimeOffset>());
        }


        lock (FacilityCallLog)
        {
            lock (IntegratorCallLog)
            {
                FacilityCallLog[facility].Add(now);
                while (FacilityCallLog[facility].Count > FacilityLimitCount)
                    FacilityCallLog[facility].RemoveAt(0);

                IntegratorCallLog[integrator].Add(now);
                while (IntegratorCallLog[integrator].Count > IntegratorLimitCount)
                    IntegratorCallLog[integrator].RemoveAt(0);
            }
        }

        await LimitDelay(facility, integrator, now);
        var result = new HttpResponseMessage();
        try
        {
            await FacilitySemaphore[facility].WaitAsync(cancellationToken);
            await IntegratorSemaphore[integrator].WaitAsync(cancellationToken);
            result = await base.SendAsync(request, cancellationToken);
            FacilitySemaphore[facility].Release();
            IntegratorSemaphore[integrator].Release();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return result;
    }

    async Task LimitDelay(string facility, string integrator, DateTimeOffset now)
    {
        lock (FacilityCallLog)
        {
            if (FacilityCallLog.Count < FacilityLimitCount && IntegratorCallLog.Count < IntegratorLimitCount) return;
        }

        var limit = now.Add(-_limitTime);

        DateTimeOffset facilityLastCall;
        bool facilityShouldLock;
        DateTimeOffset integratorLastCall;
        bool integratorShouldLock;

        lock (FacilityCallLog)
        {
            lock (IntegratorCallLog)
            {
                facilityLastCall = FacilityCallLog[facility].FirstOrDefault();
                facilityShouldLock = FacilityCallLog[facility].Count(x => x >= limit) >= FacilityLimitCount;

                integratorLastCall = IntegratorCallLog[integrator].FirstOrDefault();
                integratorShouldLock = IntegratorCallLog[integrator].Count(x => x >= limit) >= IntegratorLimitCount;
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