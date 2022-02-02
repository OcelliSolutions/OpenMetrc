using OpenMetrc.Common.Handlers;
using System;
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

        HttpClient = HttpClientFactory.Create(new RateLimitHttpMessageHandler(
            50,
            TimeSpan.FromSeconds(1)));
        HttpClient.Timeout = new TimeSpan(0, 0, 0, 30);
        //HttpClient.BaseAddress = new Uri($@"https://{domain}.metrc.com");

        //var metrcClient = new MetrcClient(HttpClient);

        //HttpClient.DefaultRequestHeaders.Authorization =
        //    new AuthenticationHeaderValue(
        //        "Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{vendorKey}:{clientKey}")));

        //MetrcService = new MetrcService(metrcClient, state, vendorKey, clientKey, isSandbox);
    }
    
    public string Domain { get; set; }
    public string VendorKey { get; set; }
    public string ClientKey { get; set; }
    public bool IsReadOnly { get; set; }
    public ICollection<Facility> Facilities { get; set; }

    internal HttpClient HttpClient { get; set; }

    internal MetrcClient MetrcClient => new(this.HttpClient){BaseUrl = $@"https://{Domain}.metrc.com", ReadResponseAsString = true};
    internal string State => Domain.Substring(Domain.Length - 2);
    internal bool IsSandbox => Domain.Length > 2;
    internal MetrcService MetrcService => new(MetrcClient, State, VendorKey, ClientKey, IsSandbox);
}