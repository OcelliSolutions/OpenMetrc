namespace OpenMetrc.Builder.Models.Requests;

public class RemediatePackageRequest
{
    public RemediatePackageRequest()
    {
        PackageLabel = string.Empty;
        RemediationMethodName = string.Empty;
        RemediationSteps = string.Empty;
    }
    public string PackageLabel { get; set; }
    public string RemediationMethodName { get; set; }
    public DateTime RemediationDate { get; set; }
    public string RemediationSteps { get; set; }
}
