﻿namespace OpenMetrc.Builder.Domain;

public class TransferType
{
    public TransferType()
    {
        Name = string.Empty;
    }

    [Required] public string Name { get; set; }

    public bool ForLicensedShipments { get; set; }
    public bool ForExternalIncomingShipments { get; set; }
    public bool ForExternalOutgoingShipments { get; set; }
    public bool RequiresDestinationGrossWeight { get; set; }
    public bool RequiresPackagesGrossWeight { get; set; }
    public string? TransactionType { get; set; }
}