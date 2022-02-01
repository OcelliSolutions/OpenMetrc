using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Diagnostics;

namespace OpenMetrc.Builder.Filters;

public class AuthorizationOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        var filterDescriptors = context.ApiDescription.ActionDescriptor.FilterDescriptors;

        ApiAuthorizationFilter? customAuthorizationFilter = (ApiAuthorizationFilter?)filterDescriptors
            .Select(filterInfo => filterInfo.Filter).FirstOrDefault(filter => filter is ApiAuthorizationFilter);
        if (customAuthorizationFilter != null)
            operation.Description +=
                $@"{(!string.IsNullOrWhiteSpace(operation.Description) ? "</br>" : "")}<b>Permissions Required</b>: {customAuthorizationFilter.PermissionDescription}";

        //var defaultValues = context.ApiDescription.CustomAttributes().Where(x => x.GetType() == typeof(MetrcEndpoint)).Select(x => x);


        MapsToApiAttribute? x = (MapsToApiAttribute?)filterDescriptors
            .Select(filterInfo => filterInfo.Filter).FirstOrDefault(filter => filter is MapsToApiAttribute);

        Debug.Assert(x?.States != null, "x?.States != null");
        operation.Description +=
            $@"</br><b>Available In</b>: { string.Join(", ", x.States) }";
    }
}
