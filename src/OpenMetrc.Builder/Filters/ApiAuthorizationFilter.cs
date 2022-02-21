using Microsoft.AspNetCore.Mvc.Filters;
using OpenMetrc.Builder.Extensions;

namespace OpenMetrc.Builder.Filters;

/// <summary>
///     If there are ApiPermissions attributed to a controller action, create a concatenated string of all the assigned
///     permissions.
/// </summary>
public class ApiAuthorizationFilter : ActionFilterAttribute
{
    private readonly List<ApiPermission>? _apiPermissions;
    public ApiAuthorizationFilter() { }

    public ApiAuthorizationFilter(ApiPermission[] permissions)
    {
        _apiPermissions = new List<ApiPermission>();
        _apiPermissions.AddRange(permissions);
    }

    public string PermissionDescription
    {
        get
        {
            if (_apiPermissions == null || !_apiPermissions.Any()) return "<i>none</i>";
            var displayNames = _apiPermissions.Select(permission => permission.GetDisplayName());
            return string.Join(" • ", displayNames);
        }
    }
}