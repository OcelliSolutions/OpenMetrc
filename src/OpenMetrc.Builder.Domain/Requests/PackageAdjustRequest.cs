namespace OpenMetrc.Builder.Domain.Requests;

public class PackageAdjustRequest
{
    public PackageAdjustRequest()
    {
        Label = string.Empty;
        UnitOfMeasure = string.Empty;
        AdjustmentReason = string.Empty;
    }

    [Required] public string Label { get; set; }

    public double Quantity { get; set; }
    public string UnitOfMeasure { get; set; }
    public string AdjustmentReason { get; set; }
    public DateTime AdjustmentDate { get; set; }
    public string? ReasonNote { get; set; }
}