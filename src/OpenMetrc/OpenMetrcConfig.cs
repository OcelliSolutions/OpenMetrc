using System.Text.Json.Serialization;

namespace OpenMetrc;

public class OpenMetrcConfig
{
    public OpenMetrcConfig(string subDomain, string softwareApiKey, string userApiKey,
        bool returnEmptyOnNotSupported = false, int callsPerSecondPerFacility = 50, int callsPerSecondPerIntegrator = 150, int concurrentCallsPerSecondPerFacility = 10, int concurrentCallsPerSecondPerIntegrator = 30)
    {
        SubDomain = subDomain;
        SoftwareApiKey = softwareApiKey;
        UserApiKey = userApiKey;
        ReturnEmptyOnNotSupported = returnEmptyOnNotSupported;
        CallsPerSecondPerFacility = callsPerSecondPerFacility;
        CallsPerSecondPerIntegrator = callsPerSecondPerIntegrator;
        ConcurrentCallsPerSecondPerFacility = concurrentCallsPerSecondPerFacility;
        ConcurrentCallsPerSecondPerIntegrator = concurrentCallsPerSecondPerIntegrator;
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
}