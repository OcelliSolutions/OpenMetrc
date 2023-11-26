using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenMetrc.Builder.Common.Filters;

/// <summary>
///     All dates in the schemas must follow a very specific format.
/// </summary>
public class DateTimeSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type == typeof(DateTimeOffset))
        {
            schema.Format = "date-time";
            schema.Description += "The date is in ISO 8601 date format yyyy-mm-ddThh:mm:ssZ.";
            schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})T([0-9]{2}):([0-9]{2}):([0-9]{2})Z";
        }
        if (context.Type == typeof(DateTimeOffset?))
        {
            schema.Format = "date-time";
            schema.Description += "The date is in ISO 8601 date format yyyy-mm-ddThh:mm:ssZ.";
            schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})T([0-9]{2}):([0-9]{2}):([0-9]{2})Z";
        }
        if (context.Type == typeof(DateTime))
        {
            schema.Format = "date";
            schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})";
        }
        if (context.Type == typeof(DateTime?))
        {
            schema.Format = "date";
            schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})";
        }
        if (context.Type == typeof(DateOnly))
        {
            schema.Format = "date";
            schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})";
        }
        if (context.Type == typeof(DateOnly?))
        {
            schema.Format = "date";
            schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})";
        }
    }
}