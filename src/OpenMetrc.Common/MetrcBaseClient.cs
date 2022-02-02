using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;

namespace OpenMetrc.Common;

public interface IMetrcBaseClient
{
    public void ConfigureClient(string state, string softwareApiKey, string userApiKey, bool isSandbox);
}

public abstract class MetrcBaseClient : IMetrcBaseClient
{
    private bool _isSandbox;
    private string? _softwareApiKey;
    private string? _state;
    private string? _userApiKey;

    protected string Domain => $@"{(_isSandbox ? "sandbox-" : "")}api-{_state}";

    public void ConfigureClient(string state, string softwareApiKey, string userApiKey, bool isSandbox)
    {
        _isSandbox = isSandbox;
        _state = state;
        _softwareApiKey = softwareApiKey;
        _userApiKey = userApiKey;
    }

    protected Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(_state) || string.IsNullOrWhiteSpace(_softwareApiKey) ||
            string.IsNullOrWhiteSpace(_userApiKey))
            throw new InvalidCredentialException("Configure using `ConfigureClient` with credentials before use");
        var msg = new HttpRequestMessage();

        msg.Headers.Authorization =
            new AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_softwareApiKey}:{_userApiKey}")));

        return Task.FromResult(msg);
    }
}