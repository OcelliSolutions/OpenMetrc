namespace OpenMetrc.Builder.Domain;
public class TransferHub
{
    public long Id { get; set; }
    public string? ManifestNumber { get; set; }
    public string? ShipperFacilityLicenseNumber { get; set; }
    public string? ShipperFacilityName { get; set; }
    public int? DeliveryCount { get; set; }
    public int? ReceivedDeliveryCount { get; set; }
    public int? PackageCount { get; set; }
    public int? ReceivedPackageCount { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string? CreatedByUserName { get; set; }
    public DateTime? LastModified { get; set; }
    public long? DeliveryId { get; set; }
    public string? RecipientFacilityLicenseNumber { get; set; }
    public string? RecipientFacilityName { get; set; }
    public string? ShipmentTypeName { get; set; }
    public int? ShipmentTransactionType { get; set; }
    public DateTime? EstimatedDepartureDateTime { get; set; }
    public DateTime? ActualDepartureDateTime { get; set; }
    public DateTime? EstimatedArrivalDateTime { get; set; }
    public DateTime? ActualArrivalDateTime { get; set; }
    public int? DeliveryPackageCount { get; set; }
    public int? DeliveryReceivedPackageCount { get; set; }
    public DateTime? ReceivedDateTime { get; set; }
    public DateTime? EstimatedReturnDepartureDateTime { get; set; }
    public DateTime? ActualReturnDepartureDateTime { get; set; }
    public DateTime? EstimatedReturnArrivalDateTime { get; set; }
    public DateTime? ActualReturnArrivalDateTime { get; set; }
    public bool? RejectedPackagesReturned { get; set; }
    public string? TransporterFacilityLicenseNumber { get; set; }
    public string? TransporterFacilityName { get; set; }
    public string? DriverName { get; set; }
    public string? DriverOccupationalLicenseNumber { get; set; }
    public string? DriverVehicleLicenseNumber { get; set; }
    public string? VehicleMake { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleLicensePlateNumber { get; set; }
    public DateTime? TransporterAcceptedDateTime { get; set; }
    public bool? IsLayover { get; set; }
    public DateTime? TransporterEstimatedDepartureDateTime { get; set; }
    public DateTime? TransporterActualDepartureDateTime { get; set; }
    public DateTime? TransporterEstimatedArrivalDateTime { get; set; }
    public DateTime? TransporterActualArrivalDateTime { get; set; }
}
