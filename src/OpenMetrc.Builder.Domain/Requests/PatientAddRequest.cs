namespace OpenMetrc.Builder.Domain.Requests;

public class PatientAddRequest
{
    public PatientAddRequest()
    {
        LicenseNumber = string.Empty;
    }

    [Required] public string LicenseNumber { get; set; }

    [Required] public DateTime LicenseEffectiveStartDate { get; set; }

    [Required] public DateTime LicenseEffectiveEndDate { get; set; }

    [Required] public int RecommendedPlants { get; set; }

    [Required] public double RecommendedSmokableQuantity { get; set; }

    [Required] public bool HasSalesLimitExemption { get; set; }

    [Required] public DateTime ActualDate { get; set; }
}