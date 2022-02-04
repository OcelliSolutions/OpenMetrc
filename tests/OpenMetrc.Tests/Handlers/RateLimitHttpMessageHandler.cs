using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace OpenMetrc.Tests.Handlers;

internal class RateLimitHttpMessageHandler : DelegatingHandler
{
    private readonly List<DateTimeOffset> _callLog = new();
    private readonly int _limitCount;
    private readonly TimeSpan _limitTime;

    public RateLimitHttpMessageHandler(int limitCount, TimeSpan limitTime)
    {
        _limitCount = limitCount;
        _limitTime = limitTime;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var now = DateTimeOffset.UtcNow;

        lock (_callLog)
        {
            _callLog.Add(now);

            while (_callLog.Count > _limitCount)
                _callLog.RemoveAt(0);
        }

        await this.LimitDelay(now);

        return await base.SendAsync(request, cancellationToken);
    }

    private async Task LimitDelay(DateTimeOffset now)
    {
        if (_callLog.Count < _limitCount)
            return;

        var limit = now.Add(-_limitTime);

        var lastCall = DateTimeOffset.MinValue;
        var shouldLock = false;

        lock (_callLog)
        {
            lastCall = _callLog.FirstOrDefault();
            shouldLock = _callLog.Count(x => x >= limit) >= _limitCount;
        }

        var delayTime = shouldLock && lastCall > DateTimeOffset.MinValue
            ? limit - lastCall
            : TimeSpan.Zero;

        if (delayTime > TimeSpan.Zero)
            await Task.Delay(delayTime);
    }
}