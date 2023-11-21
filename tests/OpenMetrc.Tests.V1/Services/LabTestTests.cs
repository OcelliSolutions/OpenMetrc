using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;

namespace OpenMetrc.Tests.V1.Services;

public class LabTestTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetLabTestTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var items = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.LabTests.GetLabTestTypesAsync().Result);
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
    public void GetLabTestStatesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var items = sharedFixture.SafeExecutor(
                    () => apiKey.MetrcService.LabTests.GetLabTestStatesAsync().Result);
                testEndpointResult.WasTested = testEndpointResult.WasTested || items.Any();
                Assert.NotEmpty(items);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [Fact(Skip = "This is only testable with a valid package id that has test results")]
    public void GetLabTestResultsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var packageId = 0;
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var items = sharedFixture.SafeExecutor(() => apiKey.MetrcService.LabTests.GetLabTestResultsAsync(
                        packageId,
                        facility.License.Number).Result);
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