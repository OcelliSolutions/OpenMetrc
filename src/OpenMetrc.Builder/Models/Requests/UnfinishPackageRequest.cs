namespace OpenMetrc.Builder.Models.Requests;

public class UnfinishPackageRequest
{
    public UnfinishPackageRequest()
    {
        Label = string.Empty;
    }

    public string Label { get; set; }
}