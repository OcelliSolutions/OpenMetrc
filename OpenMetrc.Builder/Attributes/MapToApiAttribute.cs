using Microsoft.AspNetCore.Mvc.Filters;

namespace OpenMetrc.Builder.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class MapsToApiAttribute : ActionFilterAttribute
{
    public MapsToApiAttribute(MetrcEndpoint endpoint)
    {
        Endpoint = endpoint;
    }
    public MetrcEndpoint Endpoint { get; set; }
    public IEnumerable<string> States => MetrcEndpointExtensions.GetStates(Endpoint);
}
