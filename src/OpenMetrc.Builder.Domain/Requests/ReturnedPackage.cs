namespace OpenMetrc.Builder.Domain.Requests;

public class ReturnedPackage
{
    public string? Label { get; set; }
    public decimal ReturnQuantityVerified { get; set; }
    public string? ReturnUnitOfMeasure { get; set; }
    public string? ReturnReason { get; set; }
    public string? ReturnReasonNote { get; set; }
}