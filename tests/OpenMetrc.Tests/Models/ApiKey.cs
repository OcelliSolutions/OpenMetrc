using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using OpenMetrc.Common.Handlers;

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

        var httpClient = HttpClientFactory.Create(new RateLimitHttpMessageHandler(
            50,
            TimeSpan.FromSeconds(1)));
        httpClient.BaseAddress = new Uri($@"https://{domain}.metrc.com");

        var metrcClient = new MetrcClient(httpClient);

        httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{vendorKey}:{clientKey}")));


        var state = domain.Substring(domain.Length - 2);
        var isSandbox = domain.Length > 2;
        MetrcService = new MetrcService(metrcClient, state, vendorKey, clientKey, isSandbox);
    }

    public string Domain { get; set; }
    public string VendorKey { get; set; }
    public string ClientKey { get; set; }
    public bool IsReadOnly { get; set; }
    public ICollection<Facility> Facilities { get; set; }
    internal MetrcService MetrcService { get; set; }
}