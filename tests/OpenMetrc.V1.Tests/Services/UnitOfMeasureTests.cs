using OpenMetrc.V1.Tests.Fixtures;
using OpenMetrc.V1.Tests.Helpers;

namespace OpenMetrc.V1.Tests.Services;

public class UnitOfMeasureTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetUnitOfMeasureActiveAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();


        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var unitOfMeasures = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.UnitOfMeasures.GetUnitOfMeasureActiveAsync().Result);
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