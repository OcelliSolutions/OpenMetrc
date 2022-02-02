namespace OpenMetrc.Builder.Models;

public class Transfer
{
    public int Id { get; set; }
    [MaxLength(100)] public string? ManifestNumber { get; set; }
    [MaxLength(100)] public string? ShipmentLicenseType { get; set; }
    [MaxLength(100)] public string? ShipperFacilityLicenseNumber { get; set; }
    [MaxLength(100)] public string? ShipperFacilityName { get; set; }
    [MaxLength(100)] public string? Name { get; set; }
    [MaxLength(100)] public string? TransporterFacilityLicenseNumber { get; set; }
    [MaxLength(100)] public string? TransporterFacilityName { get; set; }
    [MaxLength(100)] public string? DriverName { get; set; }
    [MaxLength(100)] public string? DriverOccupationalLicenseNumber { get; set; }
    [MaxLength(100)] public string? DriverVehicleLicenseNumber { get; set; }
    [MaxLength(100)] public string? VehicleMake { get; set; }
    [MaxLength(100)] public string? VehicleModel { get; set; }
    [MaxLength(100)] public string? VehicleLicensePlateNumber { get; set; }
    public int? DeliveryCount { get; set; }
    public int? ReceivedDeliveryCount { get; set; }
    public int? PackageCount { get; set; }
    public int? ReceivedPackageCount { get; set; }
    public bool? ContainsPlantPackage { get; set; }
    public bool? ContainsProductPackage { get; set; }
    public bool? ContainsTradeSample { get; set; }
    public bool? ContainsDonation { get; set; }
    public bool? ContainsTestingSample { get; set; }
    public bool? ContainsProductRequiresRemediation { get; set; }
    public bool? ContainsRemediatedProductPackage { get; set; }
    public DateTimeOffset CreatedDateTime { get; set; }
    [MaxLength(100)] public string? CreatedByUserName { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public int? DeliveryId { get; set; }
    [MaxLength(100)] public string? RecipientFacilityLicenseNumber { get; set; }
    [MaxLength(100)] public string? RecipientFacilityName { get; set; }
    [MaxLength(100)] public string? ShipmentTypeName { get; set; }
    [MaxLength(100)] public string? ShipmentTransactionType { get; set; }
    public DateTimeOffset? EstimatedDepartureDateTime { get; set; }
    public DateTimeOffset? ActualDepartureDateTime { get; set; }
    public DateTimeOffset? EstimatedArrivalDateTime { get; set; }
    public DateTimeOffset? ActualArrivalDateTime { get; set; }
    public int DeliveryPackageCount { get; set; }
    public int DeliveryReceivedPackageCount { get; set; }
    public DateTimeOffset? ReceivedDateTime { get; set; }
    public DateTimeOffset? EstimatedReturnDepartureDateTime { get; set; }
    public DateTimeOffset? ActualReturnDepartureDateTime { get; set; }
    public DateTimeOffset? EstimatedReturnArrivalDateTime { get; set; }
    public DateTimeOffset? ActualReturnArrivalDateTime { get; set; }
}