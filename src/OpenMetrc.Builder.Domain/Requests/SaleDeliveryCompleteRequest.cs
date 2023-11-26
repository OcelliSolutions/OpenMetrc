namespace OpenMetrc.Builder.Domain.Requests;

public class SaleDeliveryCompleteRequest
{
    public long Id { get; set; }
    public DateTime? ActualArrivalDateTime { get; set; }
    public List<string>? AcceptedPackages { get; set; }
    public List<ReturnedPackage>? ReturnedPackages { get; set; }
}