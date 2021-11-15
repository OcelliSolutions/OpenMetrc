using OpenMetrc.Client;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Tests.Helpers;

public class AdditionalPropertiesHelper
{
    public AdditionalPropertiesHelper(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    private readonly ITestOutputHelper _testOutputHelper;
    public void CheckAdditionalProperties(object obj, string path)
    {
        if (obj == null) return;
        var objType = obj.GetType();
        var properties = objType.GetProperties();
        foreach (var property in properties)
        {
            var currentPath = $@"{path}.{property.Name}";
            var propValue = property.GetValue(obj, null);
            if (property.PropertyType.Assembly == objType.Assembly && property.Name != nameof(Facility.AdditionalProperties))
            {
                //_testOutputHelper.WriteLine(currentPath);
                CheckAdditionalProperties(propValue, currentPath);
            }
            else if (property.Name == nameof(Facility.AdditionalProperties))
            {
                if (propValue != null && ((IDictionary<string, object>)propValue).Count == 0) continue;
                _testOutputHelper.WriteLine("{0}: {1}", currentPath, JsonSerializer.Serialize(propValue));
                if (propValue == null) continue;

                Assert.Equal(0, ((IDictionary<string, object>)propValue).Count);
            }
        }
    }
}
