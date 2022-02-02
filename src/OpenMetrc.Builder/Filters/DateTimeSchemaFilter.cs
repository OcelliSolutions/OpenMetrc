using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenMetrc.Builder.Filters;

public class DateTimeSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (schema.Format == "date-time-offset")
        {
            schema.Format = "date-time";
            schema.Description += "The date is in ISO 8601 date format yyyy-mm-ddThh:mm:ssZ.";
            schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})T([0-9]{2}):([0-9]{2}):([0-9]{2})Z";
        }
        else if (schema.Format == "date-time")
        {
            schema.Format = "date";
            schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})";
        }
    }
}