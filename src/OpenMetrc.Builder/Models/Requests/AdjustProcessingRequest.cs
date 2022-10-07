namespace OpenMetrc.Builder.Models.Requests;

public class AdjustProcessingRequest
{
    [Required]
    public int Id { get; set; }
    public string? AdjustmentReason { get; set; }
    public DateTime? AdjustmentDate { get; set; }
    public string? AdjustmentNote { get; set; }
    public string? CountUnitOfMeasureName { get; set; }
    public string? VolumeUnitOfMeasureName { get; set; }
    public string? WeightUnitOfMeasureName { get; set; }
    public List<ProcessingPackageRequest>? Packages { get; set; }
}
