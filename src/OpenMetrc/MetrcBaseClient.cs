using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;

namespace OpenMetrc;

public interface IMetrcBaseClient
{
    public void ConfigureClient(string softwareApiKey, string userApiKey);
}

public abstract class MetrcBaseClient : IMetrcBaseClient
{
    private string? _softwareApiKey;
    private string? _userApiKey;

    public void ConfigureClient(string softwareApiKey, string userApiKey)
    {
        _softwareApiKey = softwareApiKey;
        _userApiKey = userApiKey;
    }

    protected Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(_softwareApiKey) || string.IsNullOrWhiteSpace(_userApiKey))
            throw new InvalidCredentialException("Configure using `ConfigureClient` with credentials before use");
        var msg = new HttpRequestMessage();

        msg.Headers.Authorization =
            new AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_softwareApiKey}:{_userApiKey}")));

        return Task.FromResult(msg);
    }
}