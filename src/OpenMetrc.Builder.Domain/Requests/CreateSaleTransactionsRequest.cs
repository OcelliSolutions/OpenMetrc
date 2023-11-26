namespace OpenMetrc.Builder.Domain.Requests;

public class CreateSaleTransactionsRequest
{
    public string? PackageLabel { get; set; }
    public double? Quantity { get; set; }
    public string? UnitOfMeasure { get; set; }
    public double? TotalAmount { get; set; }
    public string? UnitThcPercent { get; set; }
    public string? UnitThcContent { get; set; }
    public string? UnitThcContentUnitOfMeasure { get; set; }
    public string? UnitWeight { get; set; }
    public string? UnitWeightUnitOfMeasure { get; set; }
    public string? InvoiceNumber { get; set; }
    public double? Price { get; set; }
    public double? ExciseTax { get; set; }
    public double? CityTax { get; set; }
    public double? CountyTax { get; set; }
    public double? MunicipalTax { get; set; }
    public double? DiscountAmount { get; set; }
    public double? SubTotal { get; set; }
    public double? SalesTax { get; set; }
}