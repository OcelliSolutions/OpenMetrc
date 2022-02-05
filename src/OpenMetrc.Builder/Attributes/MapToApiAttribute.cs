using Microsoft.AspNetCore.Mvc.Filters;

namespace OpenMetrc.Builder.Attributes;

/// <summary>
/// In order to ensure that all of the possible endpoints (from the docs) have an implementation, each controller actions must be attributed to a doc endpoint. This also aids in document tracing.
/// </summary>
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