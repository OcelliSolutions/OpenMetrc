// ReSharper disable once CheckNamespace

namespace OpenMetrc;

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