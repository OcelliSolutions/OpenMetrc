namespace OpenMetrc.Builder.Domain.Requests;

public class CreatePackageRequest
{
    public CreatePackageRequest()
    {
        Tag = string.Empty;
        Item = string.Empty;
        UnitOfMeasure = string.Empty;
    }

    [Required] public string Tag { get; set; }

    public string? Location { get; set; }

    [Required] public string Item { get; set; }

    [Required] public double Quantity { get; set; }

    [Required] public string UnitOfMeasure { get; set; }

    public string? PatientLicenseNumber { get; set; }
    public string? Note { get; set; }

    [Required] public bool IsProductionBatch { get; set; }

    public string? ProductionBatchNumber { get; set; }

    [Required] public bool IsDonation { get; set; }

    [Required] public bool ProductRequiresRemediation { get; set; }

    [Required] public bool UseSameItem { get; set; }

    [Required] public DateTime ActualDate { get; set; }

    public List<Ingredient>? Ingredients { get; set; }
}