using System;
using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Models;

public class Patient
{
    public int PatientId { get; set; }
    [MaxLength(100)] public string? LicenseNumber { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public DateTime? LicenseEffectiveStartDate { get; set; }
    public DateTime? LicenseEffectiveEndDate { get; set; }
    public int? RecommendedPlants { get; set; }
    public double? RecommendedSmokableQuantity { get; set; }
    public bool? HasSalesLimitExemption { get; set; }
    public int? OtherFacilitiesCount { get; set; }
}
