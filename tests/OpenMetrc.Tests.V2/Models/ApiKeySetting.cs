using System.Text.Json.Serialization;

namespace OpenMetrc.Tests.V2.Models;

internal class ApiKeySetting
{
    [JsonPropertyName("days_to_test")] public int DaysToTest { get; set; } = 1;

    [JsonPropertyName("configs")] public List<OpenMetrcConfig>? OpenMetrcConfigs { get; set; }

    [JsonPropertyName("disabled_configs")] public List<OpenMetrcConfig>? DisabledOpenMetrcConfigs { get; set; }
}