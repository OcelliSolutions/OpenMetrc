namespace OpenMetrc.Builder.Models;

public class License
{
    [JsonPropertyName("Number")]
    public string? Number { get; set; }

    [JsonPropertyName("StartDate")]
    public DateTime? StartDate { get; set; }

    [JsonPropertyName("EndDate")]
    public DateTime? EndDate { get; set; }

    [JsonPropertyName("LicenseType")]
    public string? LicenseType { get; set; }
}
