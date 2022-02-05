namespace OpenMetrc.Builder.Models;

public class PatientStatus
{
    public PatientStatus()
    {
        PatientLicenseNumber = string.Empty;
    }

    public string PatientLicenseNumber { get; set; }
    public bool Active { get; set; }
    public double FlowerOuncesAvailable { get; set; }
    public double ThcOuncesAvailable { get; set; }
    public double PurchaseAmountDays { get; set; }
}