namespace OpenMetrc.Builder.Models;

public class LabTestType
{
    [Required]
    public int Id { get; set; }
    [MaxLength(100)] public string? Name { get; set; }
    public bool? RequiresTestResult { get; set; }
    public bool? InformationalOnly { get; set; }
    public bool? AlwaysPasses { get; set; }
    public string? LabTestResultMode { get; set; }
    public double? LabTestResultMinimum { get; set; }
    public double? LabTestResultMaximum { get; set; }
    public string? DependencyMode { get; set; }
}