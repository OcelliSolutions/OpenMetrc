using System.Diagnostics;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenMetrc.Builder.Filters;

/// <summary>
/// Add the permissions required and the available states to the endpoint description.
/// </summary>
public class AuthorizationOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        var filterDescriptors = context.ApiDescription.ActionDescriptor.FilterDescriptors;

        var customAuthorizationFilter = (ApiAuthorizationFilter?)filterDescriptors
            .Select(filterInfo => filterInfo.Filter).FirstOrDefault(filter => filter is ApiAuthorizationFilter);
        if (customAuthorizationFilter != null)
        {
            operation.Description +=
                $@"{(!string.IsNullOrWhiteSpace(operation.Description) ? "</br>" : "")}<b>Permissions Required</b>: {customAuthorizationFilter.PermissionDescription}";
        }
        
        var x = (MapsToApiAttribute?)filterDescriptors
            .Select(filterInfo => filterInfo.Filter).FirstOrDefault(filter => filter is MapsToApiAttribute);

        Debug.Assert(x?.States != null, "x?.States != null");
        operation.Description +=
            $@"</br><b>Available In</b>: {string.Join(", ", x.States)}";
    }
}