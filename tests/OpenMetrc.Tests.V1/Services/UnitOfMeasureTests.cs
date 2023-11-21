using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;

namespace OpenMetrc.Tests.V1.Services;

public class UnitOfMeasureTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetUnitsOfMeasureAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();


        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var unitOfMeasures = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.UnitOfMeasures.GetUnitsOfMeasureAsync().Result);
                if (unitOfMeasures == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || unitOfMeasures.Any();
                foreach (var unitOfMeasure in unitOfMeasures)
                    _additionalPropertiesHelper.CheckAdditionalProperties(unitOfMeasure, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}