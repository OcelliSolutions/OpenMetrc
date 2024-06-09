using System.Text.Json;

namespace OpenMetrc.V2;
public class MetrcBaseClient
{
    public static JsonSerializerOptions DefaultJsonSerializerSettings(JsonSerializerOptions settings) => new() { PropertyNameCaseInsensitive = true };
}
