namespace OpenMetrc.Builder.Models;

public class ItemCategory
{
    [MaxLength(100)] public string? Name { get; set; }
    [MaxLength(100)] public string? ProductCategoryType { get; set; }
    [MaxLength(100)] public string? QuantityType { get; set; }
    public bool? RequiresStrain { get; set; }
    public bool? RequiresItemBrand { get; set; }
    public bool? RequiresAdministrationMethod { get; set; }
    public bool? RequiresUnitCbdPercent { get; set; }
    public bool? RequiresUnitCbdContent { get; set; }
    public bool? RequiresUnitCbdContentDose { get; set; }
    public bool? RequiresUnitThcPercent { get; set; }
    public bool? RequiresUnitThcContent { get; set; }
    public bool? RequiresUnitThcContentDose { get; set; }
    public bool? RequiresUnitVolume { get; set; }
    public bool? RequiresUnitWeight { get; set; }
    public bool? RequiresServingSize { get; set; }
    public bool? RequiresSupplyDurationDays { get; set; }
    public bool? RequiresNumberOfDoses { get; set; }
    public bool? RequiresIngredients { get; set; }
    public bool? RequiresDescription { get; set; }
    public bool? RequiresProductPhoto { get; set; }
    public bool? RequiresLabelPhotos { get; set; }
    public bool? RequiresPackagingPhotos { get; set; }
    public bool? CanContainSeeds { get; set; }
    public bool? CanBeRemediated { get; set; }
    public bool? RequiresPublicIngredients { get; set; }
    public bool? RequiresProductPhotos { get; set; }
    public bool? CanBeDestroyed { get; set; }
}
