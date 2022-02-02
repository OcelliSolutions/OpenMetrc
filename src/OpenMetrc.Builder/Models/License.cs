namespace OpenMetrc.Builder.Models;

public class License
{
    public License(string number)
    {
        Number = number;
    }

    [JsonPropertyName("Number")]
    [Required]
    public string Number { get; set; }

    [JsonPropertyName("StartDate")] public DateTime? StartDate { get; set; }

    [JsonPropertyName("EndDate")] public DateTime? EndDate { get; set; }

    [JsonPropertyName("LicenseType")] public string? LicenseType { get; set; }
}