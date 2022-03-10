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

    public string SubDomain { get; set; }

    public string SoftwareApiKey { get; set; }

    public string UserApiKey { get; set; }
    public string State => SubDomain[^2..];
    public bool IsSandbox => SubDomain.StartsWith("sandbox");
    public bool ReturnEmptyOnNotSupported { get; set; }
    public int CallsPerSecondPerFacility { get; set; }
    public int CallsPerSecondPerIntegrator { get; set; }
    public int ConcurrentCallsPerSecondPerFacility { get; set; }
    public int ConcurrentCallsPerSecondPerIntegrator { get; set; }
}