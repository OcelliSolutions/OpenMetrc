using System.Collections.Generic;

namespace OpenMetrc.Tests.Models;

public class ApiKey
{
    public ApiKey(string domain, string vendorKey, string clientKey, bool isReadOnly)
    {
        Domain = domain;
        VendorKey = vendorKey;
        ClientKey = clientKey;
        IsReadOnly = isReadOnly;
        Facilities = new HashSet<Facility>();
        Transfers = new List<Transfer>();
        TransferDeliveries = new List<TransferDelivery>();
        TransferTemplates = new List<Transfer>();
    }

    public string Domain { get; set; }
    public string VendorKey { get; set; }
    public string ClientKey { get; set; }
    public bool IsReadOnly { get; set; }
    public ICollection<Facility> Facilities { get; set; }
    public ICollection<Transfer> Transfers { get; set; }
    public ICollection<TransferDelivery> TransferDeliveries { get; set; }

    public ICollection<Transfer> TransferTemplates { get; set; }
    //public ICollection<TransferDelivery> TransferDeliveryTemplates { get; set; }

    internal string State => Domain[^2..];
    internal bool IsSandbox => Domain.Length > 2;

    internal MetrcService MetrcService => new(State, VendorKey, ClientKey, IsSandbox)
        { ReturnEmptyOnNotSupported = true };
}