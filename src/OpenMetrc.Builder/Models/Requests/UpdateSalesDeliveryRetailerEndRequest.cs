namespace OpenMetrc.Builder.Models.Requests;

public class UpdateSalesDeliveryRetailerEndRequest
{
    public long RetailerDeliveryId { get; set; }
    public DateTime ActualArrivalDateTime { get; set; }
    public SalesDeliveryPackageEnd[]? Packages { get; set; }
}

public class SalesDeliveryPackageEnd
{
    public string? Label { get; set; }
    public decimal? EndQuantity { get; set; }
    public string? EndUnitOfMeasure { get; set; }
}
