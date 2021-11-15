namespace OpenMetrc.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class MapsToApiAttribute : Attribute
{
    public MapsToApiAttribute(MetrcEndpoint endpoint)
    {
        Endpoint = endpoint;
    }
    public MetrcEndpoint Endpoint { get; set; }
    public IEnumerable<string> States => MetrcEndpointExtensions.GetStates(Endpoint);
}
