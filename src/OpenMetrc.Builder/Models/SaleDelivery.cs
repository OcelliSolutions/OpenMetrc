namespace OpenMetrc.Builder.Models;

public class SaleDelivery
{
    [Required] public int Id { get; set; }

    public string? DeliveryNumber { get; set; }
    public string? FacilityLicenseNumber { get; set; }
    public string? FacilityName { get; set; }
    public string? TransporterFacilityId { get; set; }
    public string? TransporterFacilityLicenseNumber { get; set; }
    public string? TransporterFacilityName { get; set; }
    public DateTime? SalesDateTime { get; set; }
    public string? SalesCustomerType { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public string? ConsumerId { get; set; }
    public string? DriverEmployeeId { get; set; }
    public string? DriverName { get; set; }
    public string? DriversLicenseNumber { get; set; }
    public string? VehicleMake { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleLicensePlateNumber { get; set; }
    public string? RecipientName { get; set; }
    public string? PlannedRoute { get; set; }
    public string? Direction { get; set; }
    public DateTime? EstimatedDepartureDateTime { get; set; }
    public DateTime? ActualDepartureDateTime { get; set; }
    public DateTime? EstimatedArrivalDateTime { get; set; }
    public DateTime? ActualArrivalDateTime { get; set; }
    public DateTime? EstimatedReturnDepartureDateTime { get; set; }
    public DateTime? ActualReturnDepartureDateTime { get; set; }
    public DateTime? EstimatedReturnArrivalDateTime { get; set; }
    public DateTime? ActualReturnArrivalDateTime { get; set; }
    public int? TotalPackages { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime? AcceptedDateTime { get; set; }
    public SaleTransaction[]? Transactions { get; set; }
    public DateTime? CompletedDateTime { get; set; }
    public string? SalesDeliveryState { get; set; }
    public DateTime? VoidedDate { get; set; }
    public DateTime? RecordedDateTime { get; set; }
    public string? RecordedByUserName { get; set; }
    public DateTime? LastModified { get; set; }
}