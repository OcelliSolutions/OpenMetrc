namespace OpenMetrc.Builder.Models;

public class TransferDeliveryTransporterDetail
{
    public TransferDeliveryTransporterDetail()
    {
        DriverName = string.Empty;
        DriverOccupationalLicenseNumber = string.Empty;
        DriverVehicleLicenseNumber = string.Empty;
        VehicleMake = string.Empty;
        VehicleModel = string.Empty;
        VehicleLicensePlateNumber = string.Empty;
    }
    public string DriverName { get; set; }
    public string DriverOccupationalLicenseNumber { get; set; }
    public string DriverVehicleLicenseNumber { get; set; }
    public string VehicleMake { get; set; }
    public string VehicleModel { get; set; }
    public string VehicleLicensePlateNumber { get; set; }
    public string? ActualDriverStartDateTime { get; set; }
}
