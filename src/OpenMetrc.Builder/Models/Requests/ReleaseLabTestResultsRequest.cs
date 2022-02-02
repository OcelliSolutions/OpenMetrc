namespace OpenMetrc.Builder.Models.Requests;

public class ReleaseLabTestResultsRequest
{
    public ReleaseLabTestResultsRequest()
    {
        PackageLabel = string.Empty;
    }

    public string PackageLabel { get; set; }
}