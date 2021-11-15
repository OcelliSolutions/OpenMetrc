using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenMetrc.Builder.Filters;

/// <summary>
/// Override the defaults for how swagger makes the file. Since we do not own it, we want to allow additional values. This will be used in Integration Testing.
/// </summary>
public class AdditionalPropertiesDocumentFilter : IDocumentFilter
{
    /// <inheritdoc />
    public void Apply(OpenApiDocument openApiDoc, DocumentFilterContext context)
    {
        foreach (var (_, value) in context.SchemaRepository.Schemas
            .Where(schema => schema.Value.AdditionalProperties == null && schema.Key != nameof(ErrorResponse)))
        {
            value.AdditionalPropertiesAllowed = true;
            value.AdditionalProperties = new OpenApiSchema();
        }
    }
}