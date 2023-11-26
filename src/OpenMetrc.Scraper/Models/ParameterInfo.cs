using NJsonSchema;
using NSwag;

namespace OpenMetrc.Scraper.Models;

internal class ParameterInfo
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsOptional { get; set; }
    public JsonObjectType Type { get; set; }
    public string? Format { get; set; }
    public OpenApiParameterKind Kind { get; set; }

    public OpenApiParameter OpenApiParameter => new()
    {
        Name = Name,
        IsRequired = !IsOptional,
        Description = Description,
        Type = Type,
        Format = Format,
        Kind = Kind
    };
}