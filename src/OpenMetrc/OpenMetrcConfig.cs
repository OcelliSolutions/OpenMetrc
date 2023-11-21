using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

[assembly: InternalsVisibleTo("OpenMetrc.Tests")]
[assembly: InternalsVisibleTo("OpenMetrc.Tests.V1")]
[assembly: InternalsVisibleTo("OpenMetrc.Tests.V2")]
namespace OpenMetrc;

public class OpenMetrcConfig
{
    public OpenMetrcConfig()
    {
        SubDomain = "invalid";
        SoftwareApiKey = "not_supplied";
        UserApiKey = "not_supplied";   
        ReturnEmptyOnNotSupported = false;
        CallsPerSecondPerFacility = 50;
        CallsPerSecondPerIntegrator = 150;
        ConcurrentCallsPerSecondPerFacility = 10;
        ConcurrentCallsPerSecondPerIntegrator = 30;
        HttpTimeout = TimeSpan.FromSeconds(180);
    }
    public OpenMetrcConfig(string subDomain, string softwareApiKey, string userApiKey)
    {
        SubDomain = subDomain;
        SoftwareApiKey = softwareApiKey;
        UserApiKey = userApiKey;
        ReturnEmptyOnNotSupported = false;
        CallsPerSecondPerFacility = 50;
        CallsPerSecondPerIntegrator = 150;
        ConcurrentCallsPerSecondPerFacility = 10;
        ConcurrentCallsPerSecondPerIntegrator = 30;
        HttpTimeout = TimeSpan.FromSeconds(180);
    }
    public OpenMetrcConfig(string subDomain, string softwareApiKey, string userApiKey,
        bool returnEmptyOnNotSupported = false, int callsPerSecondPerFacility = 50, int callsPerSecondPerIntegrator = 150, int concurrentCallsPerSecondPerFacility = 10, int concurrentCallsPerSecondPerIntegrator = 30, int httpTimeoutSeconds = 180)
    {
        SubDomain = subDomain;
        SoftwareApiKey = softwareApiKey;
        UserApiKey = userApiKey;
        ReturnEmptyOnNotSupported = returnEmptyOnNotSupported;
        CallsPerSecondPerFacility = callsPerSecondPerFacility;
        CallsPerSecondPerIntegrator = callsPerSecondPerIntegrator;
        ConcurrentCallsPerSecondPerFacility = concurrentCallsPerSecondPerFacility;
        ConcurrentCallsPerSecondPerIntegrator = concurrentCallsPerSecondPerIntegrator;
        HttpTimeout = httpTimeoutSeconds <= 0
            ? new TimeSpan(0, 0, 0, 0, Timeout.Infinite)
            : TimeSpan.FromSeconds(httpTimeoutSeconds);
    }

    [JsonPropertyName("sub_domain")]
    public string SubDomain { get; set; }

    [JsonPropertyName("software_api_key")]
    public string SoftwareApiKey { get; set; }
    
    [JsonPropertyName("user_api_key")]
    public string UserApiKey { get; set; }

    [JsonPropertyName("state")]
    public string State => SubDomain[^2..];

    [JsonPropertyName("is_sandbox")]
    public bool IsSandbox => SubDomain.StartsWith("sandbox");

    [JsonPropertyName("return_empty_on_not_supported")]
    public bool ReturnEmptyOnNotSupported { get; set; }

    [JsonPropertyName("calls_per_second_per_facility")]
    public int CallsPerSecondPerFacility { get; set; }

    [JsonPropertyName("calls_per_second_per_integrator")]
    public int CallsPerSecondPerIntegrator { get; set; }

    [JsonPropertyName("concurrent_calls_per_second_per_facility")]
    public int ConcurrentCallsPerSecondPerFacility { get; set; }

    [JsonPropertyName("concurrent_calls_per_second_per_integrator")]
    public int ConcurrentCallsPerSecondPerIntegrator { get; set; }

    [JsonPropertyName("http_timeout_seconds")]
    public TimeSpan HttpTimeout { get; set; }
}