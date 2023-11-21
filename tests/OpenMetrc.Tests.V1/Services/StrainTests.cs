using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;

namespace OpenMetrc.Tests.V1.Services;

public class StrainTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActiveStrainsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var strains = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Strains.GetActiveStrainsAsync(facility.License.Number).Result);
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