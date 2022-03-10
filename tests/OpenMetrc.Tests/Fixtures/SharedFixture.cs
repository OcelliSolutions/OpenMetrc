using OpenMetrc.Tests.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace OpenMetrc.Tests.Fixtures;

public class SharedFixture : IDisposable
{
    public SharedFixture()
    {
        try
        {
            var apiKeysJson = File.ReadAllText("api_keys.json");
            Debug.Assert(!string.IsNullOrWhiteSpace(apiKeysJson), "Please create a `api_keys.json` file");

            var settings = JsonSerializer.Deserialize<ApiKeySetting>(apiKeysJson) ?? new ApiKeySetting();
            Debug.Assert(settings.OpenMetrcConfigs != null, "settings.OpenMetrcConfigs != null");

            ApiKeys = settings.OpenMetrcConfigs.Select(c => new ApiKey(c){DaysToTest = settings.DaysToTest}).ToList();
            Debug.Assert(ApiKeys != null, "Please specify some api keys in `api_keys.json` before testing");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex);
        }
        catch (Exception ex)
        {
            throw new KeyNotFoundException($@"Please create a `api_keys.json` file. {ex.Message}");
        }

        Task.Run(async () => await this.LoadFacilities()).Wait();
    }

    public List<ApiKey> ApiKeys { get; set; } = new();

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

                if (facilities == null) continue;
                var sampleFacilities = facilities.Where(f => f.IsOwner ?? false).Take(3).ToList();
                sampleFacilities.AddRange(facilities.Where(f => f.FacilityType.CanGrowPlants ?? false).Take(3));
                sampleFacilities.AddRange(facilities.Where(f => f.FacilityType.CanSellToPatients ?? false).Take(3));
                key.Facilities = sampleFacilities;
            }
            catch (ApiException<ErrorResponse?> ex)
            {
                Console.WriteLine($@"SubDomain: {key.OpenMetrcConfig.SubDomain} - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    }
}