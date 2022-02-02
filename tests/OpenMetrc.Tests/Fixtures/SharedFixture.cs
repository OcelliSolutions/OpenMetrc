using OpenMetrc.Common.Handlers;
using OpenMetrc.Tests.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using Xunit.Sdk;

namespace OpenMetrc.Tests.Fixtures;

public class SharedFixture : IAsyncLifetime
{
    public SharedFixture(IMessageSink messageSink)
    {
        MessageSink = messageSink;
    }

    public List<ApiKey> ApiKeys { get; set; }

    internal HttpClient HttpClient { get; set; }
    public IMessageSink MessageSink { get; }
    public bool Initialized { get; private set; }

    public async Task InitializeAsync()
    {
        HttpClient = HttpClientFactory.Create(new RateLimitHttpMessageHandler(
            50,
            TimeSpan.FromSeconds(1)));
        HttpClient.Timeout = new TimeSpan(0, 0, 0, 30);

        var apiKeysJson = await File.ReadAllTextAsync("api_keys.json");
        Debug.Assert(!string.IsNullOrWhiteSpace(apiKeysJson), "Please create a `api_keys.json` file");
        var apiKeys = JsonSerializer.Deserialize<IEnumerable<ApiKey>>(apiKeysJson);
        Debug.Assert(apiKeys != null, "Please specify some api keys in `api_keys.json` before testing");
        ApiKeys = apiKeys.ToList();
        foreach (var apiKey in ApiKeys) apiKey.HttpClient = HttpClient;
        await this.LoadFacilities();
        await Task.Run(() => { Initialized = true; });
    }

    public async Task DisposeAsync() =>
        await Task.Run(
            () => MessageSink.OnMessage(
                new DiagnosticMessage("Disposed async.")));

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