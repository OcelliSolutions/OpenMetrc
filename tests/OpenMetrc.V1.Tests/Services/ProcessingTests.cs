using OpenMetrc.V1.Tests.Fixtures;
using OpenMetrc.V1.Tests.Helpers;

namespace OpenMetrc.V1.Tests.Services;

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
                        apiKey.MetrcService.Processing.GetProcessingJobTypeActiveAsync(facility.License.Number, null, null).Result);
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
    public void GetProcessingJobTypeCategoriesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var jobTypeCategories = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Processing.GetProcessingJobTypeCategoriesAsync(facility.License.Number).Result);
                    testEndpointResult.WasTested = testEndpointResult.WasTested || jobTypeCategories.Any();
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetProcessingJobTypeAttributesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var jobTypeAttributes = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Processing.GetProcessingJobTypeAttributesAsync(facility.License.Number).Result);
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