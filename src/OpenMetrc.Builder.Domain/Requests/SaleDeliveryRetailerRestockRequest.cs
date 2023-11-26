namespace OpenMetrc.Builder.Domain.Requests;

public class SaleDeliveryRetailerRestockRequest
{
    public long RetailerDeliveryId { get; set; }
    public DateTime DateTime { get; set; }
    public DateTime? EstimatedDepartureDateTime { get; set; }
    public SalesDeliveryDestination[]? Destinations { get; set; }
    public SalesDeliveryPackage[]? Packages { get; set; }
}