using Microsoft.AspNetCore.Mvc.Filters;

namespace OpenMetrc.Builder.Attributes;

[AttributeUsage(AttributeTargets.Method)]
internal class MapsToApiAttribute : ActionFilterAttribute
{
    internal MapsToApiAttribute(MetrcEndpoint endpoint)
    {
        Endpoint = endpoint;
    }

    internal MetrcEndpoint Endpoint { get; set; }
    internal IEnumerable<string> States => MetrcEndpointExtensions.GetStates(Endpoint);
}