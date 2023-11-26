using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace OpenMetrc.Builder.Common.Extensions;

public static class EnumExtensions
{
    public static string? GetDisplayName(this Enum enumValue) =>
        enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()?
            .GetName();
}