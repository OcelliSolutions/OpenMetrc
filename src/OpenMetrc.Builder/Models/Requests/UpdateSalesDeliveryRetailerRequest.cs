namespace OpenMetrc.Builder.Models.Requests;

public class UpdateSalesDeliveryRetailerRequest
{
    public long Id { get; set; }
    public DateTime DateTime { get; set; }
    public string? DriverEmployeeId { get; set; }
    public string? DriverName { get; set; }
    public string? DriversLicenseNumber { get; set; }
    public string? PhoneNumberForQuestions { get; set; }
    public string? VehicleMake { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleLicensePlateNumber { get; set; }
    public DateTime EstimatedDepartureDateTime { get; set; }
    public SalesDeliveryDestination[]? Destinations { get; set; }
    public SalesDeliveryPackage[]? Packages { get; set; }
}