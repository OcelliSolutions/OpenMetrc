namespace OpenMetrc.Builder.Models.Requests;

public class AdjustPlantBatchRequest
{
    public string? PlantBatchName { get; set; }
    public int? Quantity { get; set; }
    public string? AdjustmentReason { get; set; }
    public string? AdjustmentDate { get; set; }
    public string? ReasonNote { get; set; }
}
