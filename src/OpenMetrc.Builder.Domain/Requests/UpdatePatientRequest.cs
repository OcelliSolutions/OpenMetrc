namespace OpenMetrc.Builder.Domain.Requests;

public class UpdatePatientRequest
{
    public UpdatePatientRequest()
    {
        LicenseNumber = string.Empty;
        NewLicenseNumber = string.Empty;
    }

    public string LicenseNumber { get; set; }
    public string NewLicenseNumber { get; set; }
    public DateTime LicenseEffectiveStartDate { get; set; }
    public DateTime LicenseEffectiveEndDate { get; set; }
    public int RecommendedPlants { get; set; }
    public double RecommendedSmokableQuantity { get; set; }
    public bool HasSalesLimitExemption { get; set; }
    public DateTime ActualDate { get; set; }
}