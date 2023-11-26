using Microsoft.AspNetCore.Mvc.Filters;
using OpenMetrc.Builder.Common.Data;

namespace OpenMetrc.Builder.Common.Attributes;

/// <summary>
/// In order to ensure that all of the possible endpoints (from the docs) have an implementation, each controller actions must be attributed to a doc endpoint. This also aids in document tracing.
/// </summary>
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