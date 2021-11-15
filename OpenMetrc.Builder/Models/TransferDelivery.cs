namespace OpenMetrc.Builder.Models;

public class TransferDelivery
{
    public int Id { get; set; }
    [MaxLength(100)] public string? RecipientFacilityLicenseNumber { get; set; }
    [MaxLength(100)] public string? RecipientFacilityName { get; set; }
    [MaxLength(100)] public string? ShipmentTypeName { get; set; }
    [MaxLength(100)] public string? ShipmentTransactionType { get; set; }
    public DateTimeOffset? EstimatedDepartureDateTime { get; set; }
    public DateTimeOffset? ActualDepartureDateTime { get; set; }
    public DateTimeOffset? EstimatedArrivalDateTime { get; set; }
    public DateTimeOffset? ActualArrivalDateTime { get; set; }
    public double? GrossWeight { get; set; }
    [MaxLength(100)] public string? GrossUnitOfWeightId { get; set; }
    [MaxLength(100)] public string? GrossUnitOfWeightName { get; set; }
    public string? PlannedRoute { get; set; }
    public int DeliveryPackageCount { get; set; }
    public int DeliveryReceivedPackageCount { get; set; }
    public DateTimeOffset? ReceivedDateTime { get; set; }
    public DateTimeOffset? EstimatedReturnDepartureDateTime { get; set; }
    public DateTimeOffset? ActualReturnDepartureDateTime { get; set; }
    public DateTimeOffset? EstimatedReturnArrivalDateTime { get; set; }
    public DateTimeOffset? ActualReturnArrivalDateTime { get; set; }
    public bool? RejectedPackagesReturned { get; set; }
}
