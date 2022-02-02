using System.Collections.Generic;
using System.Net.Http;

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
    }

    public string Domain { get; set; }
    public string VendorKey { get; set; }
    public string ClientKey { get; set; }
    public bool IsReadOnly { get; set; }
    public ICollection<Facility> Facilities { get; set; }
    public HttpClient HttpClient { get; set; }

    internal MetrcClient MetrcClient => new(HttpClient)
        { BaseUrl = $@"https://{Domain}.metrc.com", ReadResponseAsString = true };

    internal string State => Domain.Substring(Domain.Length - 2);
    internal bool IsSandbox => Domain.Length > 2;

    internal MetrcService MetrcService => new(MetrcClient, State, VendorKey, ClientKey, IsSandbox)
        { ReturnEmptyOnNotSupported = true };
}