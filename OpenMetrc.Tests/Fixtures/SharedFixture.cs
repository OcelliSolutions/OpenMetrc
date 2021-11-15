using OpenMetrc.Common.Data;
using OpenMetrc.Tests.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenMetrc.Tests.Fixtures;

public class SharedFixture : IDisposable
{
    public List<ApiKey> ApiKeys { get; set; }
    public SharedFixture()
    {
        var apiKeysJson = File.ReadAllText("api_keys.json");
        Debug.Assert(!string.IsNullOrWhiteSpace(apiKeysJson), "Please create a `api_keys.json` file");
        var apiKeys = JsonSerializer.Deserialize<IEnumerable<ApiKey>>(apiKeysJson);
        Debug.Assert(apiKeys != null, "Please specify some api keys in `api_keys.json` before testing");
        ApiKeys = apiKeys.ToList();
    }
    public async Task LoadFacilities()
    {
        foreach (var key in ApiKeys)
        {
            var facilities = await key.FacilityClient.GetFacilitiesAsync();
            key.Facilities = facilities;
        }
    }
    public bool CheckEndpointAvailability(MetrcEndpoint metrcEndpoint, ApiKey apiKey)
    {
        var states = MetrcEndpointExtensions.GetStates(metrcEndpoint);
        return states.Contains(apiKey.State);
    }
    public void Dispose()
    {
        ApiKeys.Clear();
        GC.SuppressFinalize(this);
    }
}
