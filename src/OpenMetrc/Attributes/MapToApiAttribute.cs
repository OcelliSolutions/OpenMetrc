// ReSharper disable once CheckNamespace

namespace OpenMetrc.V1;

[AttributeUsage(AttributeTargets.Method)]
class MapsToApiAttribute : Attribute
{
    internal MapsToApiAttribute(MetrcEndpoint endpoint)
    {
        Endpoint = endpoint;
    }

    internal MetrcEndpoint Endpoint { get; set; }
    internal IEnumerable<string> States => MetrcEndpointExtensions.GetStates(Endpoint);
}