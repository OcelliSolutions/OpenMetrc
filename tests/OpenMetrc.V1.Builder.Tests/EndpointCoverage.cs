using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using OpenMetrc.Builder.Common.Attributes;
using OpenMetrc.Builder.Common.Data;

namespace OpenMetrc.V1.Builder.Tests;
public class ControllerMethodInfo
{
    public Type ControllerType { get; set; } = null!;
    public MethodInfo Method { get; set; } = null!;
}

public class EndpointCoverage
{
    [Fact]
    public void EnsureAllEnumValuesAreAssignedToMethods()
    {
        var usedEnumsCount = new Dictionary<MetrcEndpoint, int>();

        // Get the assembly containing the controllers
        var assembly = Assembly.Load("OpenMetrc.Builder");

        // Find all classes that are controllers
        var controllerTypes = assembly.GetTypes()
            .Where(type => type.IsSubclassOf(typeof(ControllerBase)));

        foreach (var type in controllerTypes)
        {
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                .Where(m => m.IsPublic && !m.IsDefined(typeof(NonActionAttribute)));

            foreach (var method in methods)
            {
                var attribute = method.GetCustomAttribute<MapsToApiAttribute>();
                if (attribute == null) continue;
                usedEnumsCount.TryAdd(attribute.Endpoint, 0);
                usedEnumsCount[attribute.Endpoint]++;
            }
        }

        var enumValues = Enum.GetValues(typeof(MetrcEndpoint)).Cast<MetrcEndpoint>();
        var incorrectlyUsedEnums = enumValues
            .Where(ev => usedEnumsCount.GetValueOrDefault(ev) != 1)
            .ToList();

        Assert.True(!incorrectlyUsedEnums.Any(),
            $"The following enum values ({incorrectlyUsedEnums.Count}) are not correctly used (should be used exactly once): {string.Join(", ", incorrectlyUsedEnums)}");
    }
}