namespace OpenMetrc.Builder.Models;

public class TransferDeliveryTransporter
{
    public TransferDeliveryTransporter()
    {
        TransporterFacilityLicenseNumber = string.Empty;
        TransporterFacilityName = string.Empty;
    }

    public string TransporterFacilityLicenseNumber { get; set; }
    public string TransporterFacilityName { get; set; }
    public int TransporterDirection { get; set; }
}