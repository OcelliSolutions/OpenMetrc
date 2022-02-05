namespace OpenMetrc.Builder.Models;

public class SaleReceiptTransaction
{
    public SaleReceiptTransaction()
    {
        PackageLabel = string.Empty;
        UnitOfMeasure = string.Empty;
    }

    public string PackageLabel { get; set; }
    public double Quantity { get; set; }
    public string UnitOfMeasure { get; set; }
    public double TotalAmount { get; set; }
}