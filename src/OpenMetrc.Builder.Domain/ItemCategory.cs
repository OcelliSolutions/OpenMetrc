﻿namespace OpenMetrc.Builder.Domain;

public class ItemCategory
{
    public string? Name { get; set; }
    public string? ProductCategoryType { get; set; }
    public string? QuantityType { get; set; }
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
    public int? RequiresLabelPhotos { get; set; }
    public int? RequiresPackagingPhotos { get; set; }
    public bool? CanContainSeeds { get; set; }
    public bool? CanBeRemediated { get; set; }
    public bool? RequiresPublicIngredients { get; set; }
    public int? RequiresProductPhotos { get; set; }
    public bool? CanBeDestroyed { get; set; }
    public bool? RequiresAllergens { get; set; }
    public bool? RequiresProductPhotoDescription { get; set; }
    public bool? RequiresLabelPhotoDescription { get; set; }
    public bool? RequiresPackagingPhotoDescription { get; set; }
    public bool? CanBeRevised { get; set; }
    [JsonPropertyName("RequiresProductPDFDocuments")]
    public int? RequiresProductPdfDocuments { get; set; }
    public string? LabTestBatchNames { get; set; }
}