using System.Text.Json;

namespace OpenMetrc.V1;
public class MetrcBaseClient
{
    public static JsonSerializerOptions DefaultJsonSerializerSettings(JsonSerializerOptions settings) => new() { PropertyNameCaseInsensitive = true };
}
