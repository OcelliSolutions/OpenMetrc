namespace OpenMetrc.Builder.Domain;

public class LabTestType
{
    [Required] public long Id { get; set; }
    public string? Name { get; set; }
    public bool? RequiresTestResult { get; set; }
    public bool? InformationalOnly { get; set; }
    public bool? AlwaysPasses { get; set; }
    public string? LabTestResultMode { get; set; }
    public double? LabTestResultMinimum { get; set; }
    public double? LabTestResultMaximum { get; set; }
    public string? DependencyMode { get; set; }
}