using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;

namespace OpenMetrc.Tests.V1.Services;

public class LocationTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActiveLocationsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var items = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Locations.GetActiveLocationsAsync(facility.License.Number).Result);
                    if (items == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || items.Any();
                    foreach (var item in items)
                        _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetLocationTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var items = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Locations.GetLocationTypesAsync(facility.License.Number).Result);
                    if (items == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || items.Any();
                    foreach (var item in items)
                        _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}