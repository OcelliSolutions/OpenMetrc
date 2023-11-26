namespace OpenMetrc.Builder.Domain.Requests;

public class SaleDeliveryRetailerEndRequest
{
    public long RetailerDeliveryId { get; set; }
    public DateTime ActualArrivalDateTime { get; set; }
    public SalesDeliveryPackageEnd[]? Packages { get; set; }
}