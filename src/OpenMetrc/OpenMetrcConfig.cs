namespace OpenMetrc;
public class OpenMetrcConfig
{
    public OpenMetrcConfig(string subDomain, string softwareApiKey, string userApiKey, bool returnEmptyOnNotSupported = false, int facilityLimitCount = 50, int integratorLimitCount = 150)
    {
        SubDomain = subDomain;
        SoftwareApiKey = softwareApiKey;
        UserApiKey = userApiKey;
        ReturnEmptyOnNotSupported = returnEmptyOnNotSupported;
        FacilityLimitCount = facilityLimitCount;
        IntegratorLimitCount = integratorLimitCount;
    }

    public string SubDomain { get; set; }

    public string SoftwareApiKey { get; set; }

    public string UserApiKey { get; set; }
    public string State => SubDomain[^2..];
    public bool IsSandbox => SubDomain.StartsWith("sandbox");
    public bool ReturnEmptyOnNotSupported { get; set; }
    public int FacilityLimitCount { get; set; }
    public int IntegratorLimitCount { get; set; }
}
