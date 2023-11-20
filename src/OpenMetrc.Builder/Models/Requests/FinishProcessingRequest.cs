namespace OpenMetrc.Builder.Models.Requests;

public class FinishProcessingRequest
{
    [Required]
    public long Id { get; set; }
    public DateTime? FinishDate { get; set; }
    public string? FinishNote { get; set; }
    public double? TotalCountWaste { get; set; }
    public string? WasteCountUnitOfMeasureName { get; set; }
    public double? TotalVolumeWaste { get; set; }
    public string? WasteVolumeUnitOfMeasureName { get; set; }
    public double? TotalWeightWaste { get; set; }
    public string? WasteWeightUnitOfMeasureName { get; set; }
}
