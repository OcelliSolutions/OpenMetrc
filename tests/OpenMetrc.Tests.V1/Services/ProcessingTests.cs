using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;

namespace OpenMetrc.Tests.V1.Services;

public class ProcessingTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActiveJobTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var jobTypes = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Processing.GetActiveJobTypesAsync(facility.License.Number, null, null).Result);
                    if (jobTypes == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || jobTypes.Any();
                    foreach (var jobType in jobTypes)
                        _additionalPropertiesHelper.CheckAdditionalProperties(jobType, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetJobTypeCategoriesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var jobTypeCategories = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Processing.GetJobTypeCategoriesAsync(facility.License.Number).Result);
                    testEndpointResult.WasTested = testEndpointResult.WasTested || jobTypeCategories.Any();
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetJobTypeAttributesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var jobTypeAttributes = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Processing.GetJobTypeAttributesAsync(facility.License.Number).Result);
                    if (jobTypeAttributes == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || jobTypeAttributes.Any();
                    foreach (var jobTypeAttribute in jobTypeAttributes)
                        _additionalPropertiesHelper.CheckAdditionalProperties(jobTypeAttribute, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}