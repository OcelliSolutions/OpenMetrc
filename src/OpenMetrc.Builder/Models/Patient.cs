namespace OpenMetrc.Builder.Models;

public class Patient
{
    [Required] public long PatientId { get; set; }

    public string? LicenseNumber { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public DateTime? LicenseEffectiveStartDate { get; set; }
    public DateTime? LicenseEffectiveEndDate { get; set; }
    public int? RecommendedPlants { get; set; }
    public double? RecommendedSmokableQuantity { get; set; }
    public bool? HasSalesLimitExemption { get; set; }
    public int? OtherFacilitiesCount { get; set; }
}