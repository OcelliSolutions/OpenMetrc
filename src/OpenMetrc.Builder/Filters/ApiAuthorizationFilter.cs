using Microsoft.AspNetCore.Mvc.Filters;
using OpenMetrc.Builder.Extensions;

namespace OpenMetrc.Builder.Filters;

public class ApiAuthorizationFilter : ActionFilterAttribute
{
    private readonly List<ApiPermission>? _apiPermissions;
    public ApiAuthorizationFilter() { }
    public ApiAuthorizationFilter(ApiPermission[] permissions)
    {
        _apiPermissions = new List<ApiPermission>();
        _apiPermissions.AddRange(permissions);
    }
    //public string PermissionDescription { get { return string.Join("U+0020U+2022U+0020", _apiPermissions); } }
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
