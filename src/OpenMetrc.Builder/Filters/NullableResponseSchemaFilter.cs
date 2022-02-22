using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenMetrc.Builder.Filters;

public class NullableResponseSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        //These are sub-objects that should not be nullable
        var excludeProperties = new List<string>
        {
            nameof(License), nameof(FacilityType), nameof(Ingredient)
        };

        //make all collection 
        if (schema.Type == "array" && schema.Items != null && schema.Items.OneOf.Any() && !schema.Items.OneOf.Any(s => excludeProperties.Contains(s.Reference.Id)) && !schema.Items.OneOf.Any(s => s.Reference.Id.EndsWith("Request")))
        {
            schema.Nullable = true;
        }

        if (schema.OneOf.Any() && schema.OneOf.All(s => s.Reference.Id == nameof(ErrorResponse)))
            schema.Nullable = true;
    }
}