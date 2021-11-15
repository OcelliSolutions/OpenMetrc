using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Models.Requests;

public class CreateHarvestPackageRequest
{
    public CreateHarvestPackageRequest()
    {
        Tag = string.Empty;
    }
    [Required]
    public string Tag { get; set; }
    public string? Location { get; set; }
    public string? Item { get; set; }
    public string? UnitOfWeight { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public string? Note { get; set; }
    public bool? IsProductionBatch { get; set; }
    public string? ProductionBatchNumber { get; set; }
    public bool? IsTradeSample { get; set; }
    public bool? IsDonation { get; set; }
    public bool? ProductRequiresRemediation { get; set; }
    public bool? RemediateProduct { get; set; }
    public int? RemediationMethodId { get; set; }
    public DateTime? RemediationDate { get; set; }
    public object? RemediationSteps { get; set; }
    public DateTime? ActualDate { get; set; }
    public List<Ingredient>? Ingredients { get; set; }
}
