namespace OpenMetrc.Builder.Models;

public class Transfer
{
    [Required] public int Id { get; set; }

    public string? ManifestNumber { get; set; }
    public string? ShipmentLicenseType { get; set; }
    public string? ShipperFacilityLicenseNumber { get; set; }
    public string? ShipperFacilityName { get; set; }
    public string? Name { get; set; }
    public string? TransporterFacilityLicenseNumber { get; set; }
    public string? TransporterFacilityName { get; set; }
    public string? DriverName { get; set; }
    public string? DriverOccupationalLicenseNumber { get; set; }
    public string? DriverVehicleLicenseNumber { get; set; }
    public string? VehicleMake { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleLicensePlateNumber { get; set; }
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
    public string? CreatedByUserName { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public int? DeliveryId { get; set; }
    public string? RecipientFacilityLicenseNumber { get; set; }
    public string? RecipientFacilityName { get; set; }
    public string? ShipmentTypeName { get; set; }
    public string? ShipmentTransactionType { get; set; }
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