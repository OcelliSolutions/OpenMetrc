namespace OpenMetrc.Builder.Domain.Requests;

public class PackageFinishRequest
{
    public PackageFinishRequest()
    {
        Label = string.Empty;
    }

    public string Label { get; set; }
    public DateTime ActualDate { get; set; }
}