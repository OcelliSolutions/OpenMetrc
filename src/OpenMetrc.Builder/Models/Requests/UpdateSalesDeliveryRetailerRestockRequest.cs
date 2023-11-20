namespace OpenMetrc.Builder.Models.Requests;

public class UpdateSalesDeliveryRetailerRestockRequest
{
    public long RetailerDeliveryId { get; set; }
    public DateTime DateTime { get; set; }
    public DateTime? EstimatedDepartureDateTime { get; set; }
    public SalesDeliveryDestination[]? Destinations { get; set; }
    public SalesDeliveryPackage[]? Packages { get; set; }
}
