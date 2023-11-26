namespace OpenMetrc.Builder.Domain.Requests;

public class LabTestResultReleaseRequest
{
    public LabTestResultReleaseRequest()
    {
        PackageLabel = string.Empty;
    }

    public string PackageLabel { get; set; }
}