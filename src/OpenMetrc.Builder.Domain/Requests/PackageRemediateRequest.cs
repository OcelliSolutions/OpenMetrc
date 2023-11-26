namespace OpenMetrc.Builder.Domain.Requests;

public class PackageRemediateRequest
{
    public PackageRemediateRequest()
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