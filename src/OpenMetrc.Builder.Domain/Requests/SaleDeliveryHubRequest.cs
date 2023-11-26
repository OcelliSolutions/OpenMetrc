namespace OpenMetrc.Builder.Domain.Requests;

public class SaleDeliveryHubRequest
{
    public long Id { get; set; }
    public string? TransporterFacilityId { get; set; }
    public string? DriverEmployeeId { get; set; }
    public string? DriverName { get; set; }
    public string? DriversLicenseNumber { get; set; }
    public string? PhoneNumberForQuestions { get; set; }
    public string? VehicleMake { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleLicensePlateNumber { get; set; }
    public string? PlannedRoute { get; set; }
    public DateTime EstimatedDepartureDateTime { get; set; }
    public DateTime EstimatedArrivalDateTime { get; set; }
}