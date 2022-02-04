namespace OpenMetrc.Builder.Models;

public class TransferDeliveryPackageWholesale
{
    [Required] public int PackageId { get; set; }

    [MaxLength(100)] public string? PackageLabel { get; set; }
    public double? ShipperWholesalePrice { get; set; }
    public double? ReceiverWholesalePrice { get; set; }
}