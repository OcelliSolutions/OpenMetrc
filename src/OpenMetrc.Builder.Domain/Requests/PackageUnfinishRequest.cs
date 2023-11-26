namespace OpenMetrc.Builder.Domain.Requests;

public class PackageUnfinishRequest
{
    public PackageUnfinishRequest()
    {
        Label = string.Empty;
    }

    public string Label { get; set; }
}