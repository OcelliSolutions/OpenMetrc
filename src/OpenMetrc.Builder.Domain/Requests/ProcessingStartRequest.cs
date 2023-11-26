namespace OpenMetrc.Builder.Domain.Requests;

public class ProcessingStartRequest
{
    public string JobName { get; set; } = null!;
    public string JobType { get; set; } = null!;
    public string CountUnitOfMeasure { get; set; } = null!;
    public string VolumeUnitOfMeasure { get; set; } = null!;
    public string WeightUnitOfMeasure { get; set; } = null!;
    public List<ProcessingPackageRequest>? Packages { get; set; }
    public DateTime StartDate { get; set; }
}