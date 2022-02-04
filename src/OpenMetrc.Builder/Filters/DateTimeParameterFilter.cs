using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenMetrc.Builder.Filters;

public class DateTimeParameterFilter : IParameterFilter
{
    private readonly IList<string> _timestampParameters =
        new List<string> { "lastModifiedStart", "lastModifiedEnd" }.AsReadOnly();

    public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
    {
        if (!_timestampParameters.Contains(parameter.Name)) return;
        parameter.Schema.Format = "date-time";
        parameter.Schema.Description += "The date is in ISO 8601 date format yyyy-mm-ddThh:mm:ssZ.";
        parameter.Schema.Pattern = "([0-9]{4})-(?:[0-9]{2})-([0-9]{2})T([0-9]{2}):([0-9]{2}):([0-9]{2})Z";
    }
}