namespace OpenMetrc.Builder.Models;

public class TransferDeliveryPackageWholesale
{
    public int? PackageId { get; set; }
    public string? PackageLabel { get; set; }
    public double? ShipperWholesalePrice { get; set; }
    public double? ReceiverWholesalePrice { get; set; }
}