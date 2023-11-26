namespace OpenMetrc.Builder.Domain.Requests;

public class ProcessingAdjustRequest
{
    [Required] public long Id { get; set; }

    public string? AdjustmentReason { get; set; }
    public DateTime? AdjustmentDate { get; set; }
    public string? AdjustmentNote { get; set; }
    public string? CountUnitOfMeasureName { get; set; }
    public string? VolumeUnitOfMeasureName { get; set; }
    public string? WeightUnitOfMeasureName { get; set; }
    public List<ProcessingPackageRequest>? Packages { get; set; }
}