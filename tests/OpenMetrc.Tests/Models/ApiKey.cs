using System.Collections.Generic;

namespace OpenMetrc.Tests.Models;

public class ApiKey
{
    public ApiKey(string subDomain, string softwareApiKey, string userApiKey)
    {
        SubDomain = subDomain;
        SoftwareApiKey = softwareApiKey;
        UserApiKey = userApiKey;
        Facilities = new HashSet<Facility>();
        Transfers = new List<Transfer>();
        TransferDeliveries = new List<TransferDelivery>();
        TransferTemplates = new List<Transfer>();
    }

    public string SubDomain { get; set; }
    public string SoftwareApiKey { get; set; }
    public string UserApiKey { get; set; }
    public ICollection<Facility> Facilities { get; set; }
    public ICollection<Transfer> Transfers { get; set; }
    public ICollection<TransferDelivery> TransferDeliveries { get; set; }

    public ICollection<Transfer> TransferTemplates { get; set; }
    //public ICollection<TransferDelivery> TransferDeliveryTemplates { get; set; }

    internal string State => SubDomain[^2..];
    internal bool IsSandbox => SubDomain.StartsWith("sandbox");
    public bool IsReadOnly => !IsSandbox; //only the sandbox will be written to when doing integration testing
    internal MetrcService MetrcService => new(State, SoftwareApiKey, UserApiKey, IsSandbox)
        { ReturnEmptyOnNotSupported = true };
}