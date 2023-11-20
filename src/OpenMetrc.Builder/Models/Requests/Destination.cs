namespace OpenMetrc.Builder.Models.Requests;

public class Destination
{
    public string? SalesCustomerType { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public string? ConsumerId { get; set; }
    public string? RecipientName { get; set; }
    public string? RecipientAddressStreet1 { get; set; }
    public string? RecipientAddressStreet2 { get; set; }
    public string? RecipientAddressCity { get; set; }
    public string? RecipientAddressCounty { get; set; }
    public string? RecipientAddressState { get; set; }
    public string? RecipientAddressPostalCode { get; set; }
    public DateTime? EstimatedArrivalDateTime { get; set; }
    public SalesDeliveryTransaction[]? Transactions { get; set; }
}