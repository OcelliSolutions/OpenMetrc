using OpenMetrc.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.VisualBasic;

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

        Client = HttpClientFactory.Create(new Handlers.RateLimitHttpMessageHandler(
                    limitCount: 50,
                    limitTime: TimeSpan.FromSeconds(1)));

        Client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{VendorKey}:{ClientKey}")));

        var baseUrl = $@"https://{Domain}.metrc.com";
        EmployeeClient = new EmployeeClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true};
        FacilityClient = new FacilityClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        HarvestClient = new HarvestClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        ItemClient = new ItemClient(Client) { BaseUrl= baseUrl, ReadResponseAsString = true };
        LabTestClient = new LabTestClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        LocationClient = new LocationClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        PackageClient = new PackageClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        PatientClient = new PatientClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        PlantBatchClient = new PlantBatchClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        PlantClient = new PlantClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        SaleClient = new SaleClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        StrainClient = new StrainClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        TransferClient = new TransferClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        UnitOfMeasureClient = new UnitOfMeasureClient(Client) { BaseUrl = baseUrl, ReadResponseAsString = true };
        
    }
    public string Domain { get; set; }
    public string VendorKey { get; set; }
    public string ClientKey { get; set; }
    public bool IsReadOnly { get; set; }
    public string State => Domain.Substring(Domain.Length - 2);
    public ICollection<Facility> Facilities { get; set; }
    internal HttpClient Client { get; set; }
    public IEmployeeClient EmployeeClient { get; set; }
    public IFacilityClient FacilityClient { get; set; }
    public IHarvestClient HarvestClient { get; set; }
    public IItemClient ItemClient { get; set; }
    public ILabTestClient LabTestClient { get; set; }
    public ILocationClient LocationClient { get; set; }
    public IPackageClient PackageClient { get; set; }
    public IPatientClient PatientClient { get; set; }
    public IPlantBatchClient PlantBatchClient { get; set; }
    public IPlantClient PlantClient { get; set; }
    public ISaleClient SaleClient { get; set; }
    public IStrainClient StrainClient { get; set; }
    public ITransferClient TransferClient { get; set; }
    public IUnitOfMeasureClient UnitOfMeasureClient { get; set; }
}
