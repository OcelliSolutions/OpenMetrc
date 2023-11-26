namespace OpenMetrc.Builder.Domain.Requests;

public class SalesDeliveryPackage
{
    public DateTime DateTime { get; set; }
    public string? PackageLabel { get; set; }
    public double? Quantity { get; set; }
    public string? UnitOfMeasure { get; set; }
    public double? TotalPrice { get; set; }
}