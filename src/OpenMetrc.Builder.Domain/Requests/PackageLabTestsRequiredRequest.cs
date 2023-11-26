namespace OpenMetrc.Builder.Domain.Requests;

public class PackageLabTestsRequiredRequest
{
    public string Label { get; set; } = null!;
    public string[]? RequiredLabTestBatches { get; set; }
}