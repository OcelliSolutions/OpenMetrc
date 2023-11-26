namespace OpenMetrc.Builder.Domain;

public class TransferDelivery
{
    [Required] public long Id { get; set; }

    public string? RecipientFacilityLicenseNumber { get; set; }
    public string? RecipientFacilityName { get; set; }
    public string? ShipmentTypeName { get; set; }
    public string? ShipmentTransactionType { get; set; }
    public DateTimeOffset? EstimatedDepartureDateTime { get; set; }
    public DateTimeOffset? ActualDepartureDateTime { get; set; }
    public DateTimeOffset? EstimatedArrivalDateTime { get; set; }
    public DateTimeOffset? ActualArrivalDateTime { get; set; }
    public double? GrossWeight { get; set; }
    public string? GrossUnitOfWeightId { get; set; }
    public string? GrossUnitOfWeightName { get; set; }
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