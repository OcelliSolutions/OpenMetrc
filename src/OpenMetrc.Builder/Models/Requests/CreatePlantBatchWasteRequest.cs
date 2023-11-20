namespace OpenMetrc.Builder.Models.Requests;

public class CreatePlantBatchWasteRequest
{
    public string? WasteMethodName { get; set; }
    public string? MixedMaterial { get; set; }
    public double? WasteWeight { get; set; }
    public string? UnitOfMeasureName { get; set; }
    public string? ReasonName { get; set; }
    public string? Note { get; set; }
    public string? WasteDate { get; set; }
    public string? PlantBatchName { get; set; }
}