namespace OpenMetrc.Builder.Models.Requests;

public class UpdateSaleDeliveryRequest
{
    public int Id { get; set; }
    public DateTime SalesDateTime { get; set; }
    public string? SalesCustomerType { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public string? ConsumerId { get; set; }
    public string? DriverEmployeeId { get; set; }
    public string? DriverName { get; set; }
    public string? DriversLicenseNumber { get; set; }
    public string? PhoneNumberForQuestions { get; set; }
    public string? VehicleMake { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleLicensePlateNumber { get; set; }
    public string? RecipientName { get; set; }
    public string? RecipientAddressStreet1 { get; set; }
    public string? RecipientAddressStreet2 { get; set; }
    public string? RecipientAddressCity { get; set; }
    public string? RecipientAddressCounty { get; set; }
    public string? RecipientAddressState { get; set; }
    public string? RecipientAddressPostalCode { get; set; }
    public string? PlannedRoute { get; set; }
    public DateTime? EstimatedDepartureDateTime { get; set; }
    public DateTime? EstimatedArrivalDateTime { get; set; }
    public List<SaleTransaction>? Transactions { get; set; }
}