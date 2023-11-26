namespace OpenMetrc.Builder.Domain;

public class TransferDeliveryPackage
{
    public int? PackageId { get; set; }
    public string? PackageLabel { get; set; }
    public string? PackageType { get; set; }
    public string? SourceHarvestNames { get; set; }
    public string? SourcePackageLabels { get; set; }
    public string? ProductName { get; set; }
    public string? ProductCategoryName { get; set; }
    public string? ItemId { get; set; }
    public string? ItemName { get; set; }
    public string? ItemCategoryName { get; set; }
    public string? ItemStrainName { get; set; }
    public double? ItemUnitCbdPercent { get; set; }
    public double? ItemUnitCbdContent { get; set; }
    public string? ItemUnitCbdContentUnitOfMeasureName { get; set; }
    public double? ItemUnitCbdContentDose { get; set; }
    public string? ItemUnitCbdContentDoseUnitOfMeasureName { get; set; }
    public double? ItemUnitThcPercent { get; set; }
    public double? ItemUnitThcContent { get; set; }
    public string? ItemUnitThcContentUnitOfMeasureName { get; set; }
    public double? ItemUnitThcContentDose { get; set; }
    public string? ItemUnitThcContentDoseUnitOfMeasureName { get; set; }
    public double? ItemUnitVolume { get; set; }
    public string? ItemUnitVolumeUnitOfMeasureName { get; set; }
    public double? ItemUnitWeight { get; set; }
    public string? ItemUnitWeightUnitOfMeasureName { get; set; }
    public string? ItemServingSize { get; set; }
    public int? ItemSupplyDurationDays { get; set; }
    public double? ItemUnitQuantity { get; set; }
    public string? ItemUnitQuantityUnitOfMeasureName { get; set; }
    public string? LabTestingState { get; set; }
    public string? ProductionBatchNumber { get; set; }
    public bool IsTradeSample { get; set; }
    public bool IsTradeSamplePersistent { get; set; }
    public bool IsDonation { get; set; }
    public bool SourcePackageIsDonation { get; set; }
    public bool SourcePackageIsTradeSample { get; set; }
    public bool IsTestingSample { get; set; }
    public bool ProductRequiresRemediation { get; set; }
    public bool ContainsRemediatedProduct { get; set; }
    public DateTime? RemediationDate { get; set; }
    public string? ShipmentPackageState { get; set; }
    public double ShippedQuantity { get; set; }
    public string? ShippedUnitOfMeasureName { get; set; }
    public string? GrossUnitOfWeightName { get; set; }
    public double? ReceivedQuantity { get; set; }
    public string? ReceivedUnitOfMeasureName { get; set; }
}