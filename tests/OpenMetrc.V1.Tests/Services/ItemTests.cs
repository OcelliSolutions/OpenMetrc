using OpenMetrc.V1.Tests.Fixtures;
using OpenMetrc.V1.Tests.Helpers;

namespace OpenMetrc.V1.Tests.Services;

public class ItemTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    //private const string NewItemName = "OpenMETRC Test Item";
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetItemActiveAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var items = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Items.GetItemActiveAsync(facility.License.Number).Result);
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
    public void GetItemInactiveAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var items = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Items.GetItemInactiveAsync(facility.License.Number).Result);
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
    public void GetItemBrandsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var items = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Items.GetItemBrandsAsync(facility.License.Number).Result);
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
    public void GetItemCategoriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var items = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Items.GetItemCategoriesAsync(facility.License.Number).Result);
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
    public void GetItemPhotoAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var item = apiKey.MetrcService.Items.GetItemActiveAsync(facility.License.Number).Result;
                    var itemPhoto = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Items.GetItemPhotoByIdAsync(item.First().Id, facility.License.Number).Result);
                    testEndpointResult.WasTested = testEndpointResult.WasTested || itemPhoto != null;
                    _additionalPropertiesHelper.CheckAdditionalProperties(itemPhoto, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}