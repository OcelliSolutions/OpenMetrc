using OpenMetrc.Builder.Domain.Requests;

namespace OpenMetrc.Builder.Domain;

public class Retailer
{
    public long Id { get; set; }
    public string? RetailerDeliveryNumber { get; set; }
    public string? FacilityLicenseNumber { get; set; }
    public string? FacilityName { get; set; }
    public DateTime? DateTime { get; set; }
    public string? DriverEmployeeId { get; set; }
    public string? DriverName { get; set; }
    public string? DriversLicenseNumber { get; set; }
    public string? VehicleMake { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleLicensePlateNumber { get; set; }
    public string? VehicleInfo { get; set; }
    public string? Direction { get; set; }
    public DateTime? EstimatedDepartureDateTime { get; set; }
    public DateTime? ActualDepartureDateTime { get; set; }
    public DateTime? RestockDateTime { get; set; }
    public int? TotalPackages { get; set; }
    public double? TotalPrice { get; set; }
    public double? TotalPriceSold { get; set; }
    public DateTime? AcceptedDateTime { get; set; }
    public object[]? Destinations { get; set; }
    public DateTime? CompletedDateTime { get; set; }
    public string? RetailerDeliveryState { get; set; }
    public bool? AllowFullEdit { get; set; }
    public int? Leg { get; set; }
    public DateTime? VoidedDate { get; set; }
    public DateTime? RecordedDateTime { get; set; }
    public string? RecordedByUserName { get; set; }
    public DateTime? LastModified { get; set; }
    public SalesDeliveryPackage[]? Packages { get; set; }
}