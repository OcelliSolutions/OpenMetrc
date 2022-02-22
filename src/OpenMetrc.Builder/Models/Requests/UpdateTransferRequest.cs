namespace OpenMetrc.Builder.Models.Requests;

public class UpdateTransferRequest
{
    public UpdateTransferRequest()
    {
        ShipperLicenseNumber = string.Empty;
        ShipperName = string.Empty;
    }

    public int TransferId { get; set; }

    public string ShipperLicenseNumber { get; set; }
    public string ShipperName { get; set; }
    public string? ShipperMainPhoneNumber { get; set; }
    public string? ShipperAddress1 { get; set; }
    public string? ShipperAddress2 { get; set; }
    public string? ShipperAddressCity { get; set; }
    public string? ShipperAddressState { get; set; }
    public string? ShipperAddressPostalCode { get; set; }
    public string? TransporterFacilityLicenseNumber { get; set; }
    public string? DriverOccupationalLicenseNumber { get; set; }
    public string? DriverName { get; set; }
    public string? DriverLicenseNumber { get; set; }
    public string? PhoneNumberForQuestions { get; set; }
    public string? VehicleMake { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleLicensePlateNumber { get; set; }
    public List<UpdateExternalDestination>? Destinations { get; set; }

    public class UpdateExternalDestination
    {
        public string? RecipientLicenseNumber { get; set; }
        public string? TransferTypeName { get; set; }
        public string? PlannedRoute { get; set; }
        public DateTimeOffset EstimatedDepartureDateTime { get; set; }
        public DateTimeOffset EstimatedArrivalDateTime { get; set; }
        public double? GrossWeight { get; set; }
        public string? GrossUnitOfWeightId { get; set; }
        public List<UpdateExternalTransporter>? Transporters { get; set; }
        public List<Package>? Packages { get; set; }
    }

    public class UpdateExternalTransporter
    {
        public string? TransporterFacilityLicenseNumber { get; set; }
        public string? DriverOccupationalLicenseNumber { get; set; }
        public string? DriverName { get; set; }
        public string? DriverLicenseNumber { get; set; }
        public string? PhoneNumberForQuestions { get; set; }
        public string? VehicleMake { get; set; }
        public string? VehicleModel { get; set; }
        public string? VehicleLicensePlateNumber { get; set; }
        public bool IsLayover { get; set; }
        public DateTimeOffset EstimatedDepartureDateTime { get; set; }
        public DateTimeOffset EstimatedArrivalDateTime { get; set; }
        public TransferDeliveryTransporterDetail? TransporterDetails { get; set; }
    }

    public class UpdateExternalPackage
    {
        public string? ItemName { get; set; }
        public double Quantity { get; set; }
        public string? UnitOfMeasureName { get; set; }
        public DateTimeOffset PackagedDate { get; set; }
        public double? GrossWeight { get; set; }
        public string? GrossUnitOfWeightName { get; set; }
        public double? WholesalePrice { get; set; }
    }
}