namespace OpenMetrc.Builder.Models;

public class TransferDeliveryPackage
{
    [Required]
    public int PackageId { get; set; }
    [MaxLength(100)] public string? PackageLabel { get; set; }
    [MaxLength(100)] public string? PackageType { get; set; }
    public string? SourceHarvestNames { get; set; }
    public string? SourcePackageLabels { get; set; }
    [MaxLength(200)] public string? ProductName { get; set; }
    [MaxLength(100)] public string? ProductCategoryName { get; set; }
    [MaxLength(100)] public string? ItemStrainName { get; set; }
    public double? ItemUnitCbdPercent { get; set; }
    public double? ItemUnitCbdContent { get; set; }
    [MaxLength(100)] public string? ItemUnitCbdContentUnitOfMeasureName { get; set; }
    public double? ItemUnitCbdContentDose { get; set; }
    [MaxLength(100)] public string? ItemUnitCbdContentDoseUnitOfMeasureName { get; set; }
    public double? ItemUnitThcPercent { get; set; }
    public double? ItemUnitThcContent { get; set; }
    [MaxLength(100)] public string? ItemUnitThcContentUnitOfMeasureName { get; set; }
    public double? ItemUnitThcContentDose { get; set; }
    [MaxLength(100)] public string? ItemUnitThcContentDoseUnitOfMeasureName { get; set; }
    public double? ItemUnitVolume { get; set; }
    [MaxLength(100)] public string? ItemUnitVolumeUnitOfMeasureName { get; set; }
    public double? ItemUnitWeight { get; set; }
    [MaxLength(100)] public string? ItemUnitWeightUnitOfMeasureName { get; set; }
    [MaxLength(100)] public string? ItemServingSize { get; set; }
    public int? ItemSupplyDurationDays { get; set; }
    public double? ItemUnitQuantity { get; set; }
    [MaxLength(100)] public string? ItemUnitQuantityUnitOfMeasureName { get; set; }
    [MaxLength(100)] public string? LabTestingState { get; set; }
    [MaxLength(100)] public string? ProductionBatchNumber { get; set; }
    public bool IsTradeSample { get; set; }
    public bool IsTradeSamplePersistent { get; set; }
    public bool IsDonation { get; set; }
    public bool SourcePackageIsDonation { get; set; }
    public bool SourcePackageIsTradeSample { get; set; }
    public bool IsTestingSample { get; set; }
    public bool ProductRequiresRemediation { get; set; }
    public bool ContainsRemediatedProduct { get; set; }
    public DateTime? RemediationDate { get; set; }
    [MaxLength(100)] public string? ShipmentPackageState { get; set; }
    public double ShippedQuantity { get; set; }
    [MaxLength(100)] public string? ShippedUnitOfMeasureName { get; set; }
    [MaxLength(100)] public string? GrossUnitOfWeightName { get; set; }
    public double? ReceivedQuantity { get; set; }
    [MaxLength(100)] public string? ReceivedUnitOfMeasureName { get; set; }
}