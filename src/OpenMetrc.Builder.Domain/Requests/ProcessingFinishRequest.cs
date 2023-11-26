namespace OpenMetrc.Builder.Domain.Requests;

public class ProcessingFinishRequest
{
    [Required] public long Id { get; set; }

    public DateTime? FinishDate { get; set; }
    public string? FinishNote { get; set; }
    public double? TotalCountWaste { get; set; }
    public string? WasteCountUnitOfMeasureName { get; set; }
    public double? TotalVolumeWaste { get; set; }
    public string? WasteVolumeUnitOfMeasureName { get; set; }
    public double? TotalWeightWaste { get; set; }
    public string? WasteWeightUnitOfMeasureName { get; set; }
}