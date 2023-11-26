namespace OpenMetrc.Builder.Domain.Requests;

public class CreatePlantBatchAdjustRequest
{
    public string? PlantBatchName { get; set; }
    public int? Quantity { get; set; }
    public string? AdjustmentReason { get; set; }
    public string? AdjustmentDate { get; set; }
    public string? ReasonNote { get; set; }
}