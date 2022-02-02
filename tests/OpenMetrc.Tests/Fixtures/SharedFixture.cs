using OpenMetrc.Tests.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace OpenMetrc.Tests.Fixtures;

[CollectionDefinition("Api Key collection")]
public class ApiKeyCollection : ICollectionFixture<SharedFixture>
{
    // This class has no code, and is never created. Its purpose is simply
    // to be the place to apply [CollectionDefinition] and all the
    // ICollectionFixture<> interfaces.
}
public class SharedFixture : IDisposable
{
    public SharedFixture()
    {
        var apiKeysJson = File.ReadAllText("api_keys.json");
        Debug.Assert(!string.IsNullOrWhiteSpace(apiKeysJson), "Please create a `api_keys.json` file");
        var apiKeys = JsonSerializer.Deserialize<IEnumerable<ApiKey>>(apiKeysJson);
        Debug.Assert(apiKeys != null, "Please specify some api keys in `api_keys.json` before testing");
        ApiKeys = apiKeys.ToList();
        Task.Run(LoadFacilities).Wait();
    }

    public List<ApiKey> ApiKeys { get; set; }

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
                key.Facilities = facilities;
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