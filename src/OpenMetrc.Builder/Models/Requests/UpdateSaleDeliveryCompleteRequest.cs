namespace OpenMetrc.Builder.Models.Requests;

public class UpdateSaleDeliveryCompleteRequest
{
    public int Id { get; set; }
    public DateTime? ActualArrivalDateTime { get; set; }
    public List<string>? AcceptedPackages { get; set; }
    public List<ReturnedPackage>? ReturnedPackages { get; set; }
}