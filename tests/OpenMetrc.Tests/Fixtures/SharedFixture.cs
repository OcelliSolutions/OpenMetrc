using OpenMetrc.Common.Handlers;
using OpenMetrc.Tests.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;

namespace OpenMetrc.Tests.Fixtures;

public class SharedFixture : IDisposable
{
    public SharedFixture()
    {
        HttpClient = HttpClientFactory.Create(new RateLimitHttpMessageHandler(
            10,
            TimeSpan.FromSeconds(1)));
        HttpClient.Timeout = new TimeSpan(0, 0, 0, 30);

        var apiKeysJson = File.ReadAllText("api_keys.json");
        Debug.Assert(!string.IsNullOrWhiteSpace(apiKeysJson), "Please create a `api_keys.json` file");
        var apiKeys = JsonSerializer.Deserialize<IEnumerable<ApiKey>>(apiKeysJson);
        Debug.Assert(apiKeys != null, "Please specify some api keys in `api_keys.json` before testing");
        ApiKeys = apiKeys.ToList();
        foreach (var apiKey in ApiKeys) apiKey.HttpClient = HttpClient;
        Task.Run(async () => await this.LoadFacilities()).Wait();
    }

    public List<ApiKey> ApiKeys { get; set; }
    internal HttpClient HttpClient { get; set; }

    public void Dispose()
    {
        ApiKeys.Clear();
        GC.SuppressFinalize(this);
    }

    public async Task LoadFacilities()
    {
        foreach (var key in ApiKeys)
            try
            {
                var facilities = await key.MetrcService.Facilities.GetFacilitiesAsync();
                //key.Facilities = facilities.Take(5).ToList();
                var sampleFacilities = facilities.Where(f => f.IsOwner ?? false).Take(2).ToList();
                sampleFacilities.AddRange(facilities.Where(f => f.FacilityType.CanGrowPlants ?? false).Take(2));
                sampleFacilities.AddRange(facilities.Where(f => f.FacilityType.CanSellToPatients ?? false).Take(2));
                key.Facilities = sampleFacilities;
            }
            catch (ApiException<ErrorResponse> ex)
            {
                Console.WriteLine($@"domain: {key.Domain} - {ex.Message}");
            }
            catch (ApiException ex)
            {
                Console.WriteLine($@"domain: {key.Domain} - {ex.Message}");
            }
    }
}