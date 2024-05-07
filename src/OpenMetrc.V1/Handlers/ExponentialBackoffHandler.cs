using System.Net;

namespace OpenMetrc.V1.Handlers;
public class ExponentialBackoffHandler : DelegatingHandler
{
    readonly int _maxRetries;
    readonly double _delaySeconds;
    readonly double _maxDelaySeconds;

    public ExponentialBackoffHandler(HttpMessageHandler innerHandler, int maxRetries = 3, double delaySeconds = 1.0, double maxDelaySeconds = 30.0)
        : base(innerHandler)
    {
        _maxRetries = maxRetries;
        _delaySeconds = delaySeconds;
        _maxDelaySeconds = maxDelaySeconds;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);
        for (var i = 0; i < _maxRetries; i++)
        {
            if (response.IsSuccessStatusCode || response.StatusCode is not HttpStatusCode.TooManyRequests and not HttpStatusCode.ServiceUnavailable)
                return response; // Return on success or non-retry-able status code

            var delay = Math.Min(_maxDelaySeconds, _delaySeconds * Math.Pow(2, i)); // Exponential backoff formula
            await Task.Delay(TimeSpan.FromSeconds(delay), cancellationToken);
        }

        return new HttpResponseMessage(HttpStatusCode.RequestTimeout) { ReasonPhrase = "Max retries exceeded." };
    }
}