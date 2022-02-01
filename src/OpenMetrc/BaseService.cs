using System.Diagnostics;
using OpenMetrc.Models;

namespace OpenMetrc;
public class BaseService
{
    private readonly string _state;
    protected readonly ApiKey ApiKey;
    /// <summary>
    /// METRC is not in all states and not all states have the same endpoint. If this value is true, an empty result will be returned instead of a `ReturnEmptyOnNotSupported` exception
    /// </summary>
    public bool ReturnEmptyOnNotSupported { get; set; }
    protected BaseService(string state, string softwareApiKey, string userApiKey, bool isSandbox, bool returnEmptyOnNotSupported = false)
    {
        ReturnEmptyOnNotSupported = returnEmptyOnNotSupported;
        _state = state;
        var domain = $@"{(isSandbox ? "sandbox-" : "")}api-{state}";
        ApiKey = new ApiKey(domain, softwareApiKey, userApiKey);
    }
    protected bool CheckEndpointAvailability(MethodBase? method)
    {
        Debug.Assert(method != null, nameof(method) + " != null");
        var endpoint = method.GetCustomAttributes(typeof(MapsToApiAttribute), true).FirstOrDefault() as MapsToApiAttribute;
        Debug.Assert(endpoint != null, nameof(endpoint) + " != null");
        var states = endpoint.States;
        if (states.Contains(_state)) return true;
        if (!ReturnEmptyOnNotSupported) throw new NotSupportedException("This state does not support this endpoint");
        return false;
    }
}
