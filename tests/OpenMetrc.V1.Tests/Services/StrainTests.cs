using OpenMetrc.V1.Tests.Fixtures;
using OpenMetrc.V1.Tests.Helpers;

namespace OpenMetrc.V1.Tests.Services;

public class StrainTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetStrainActiveAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var strains = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Strains.GetStrainActiveAsync(facility.License.Number).Result);
                    if (strains == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || strains.Any();
                    foreach (var strain in strains)
                        _additionalPropertiesHelper.CheckAdditionalProperties(strain, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}