using System;

namespace OpenMetrc.Tests.V1;

public class PlantTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetFloweringPlantsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetFloweringPlantsAsync(
                        facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                    break;
                }
            while (true);

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetInactivePlantsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetInactivePlantsAsync(
                        facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                    break;
                }
            while (true);

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetOnHoldPlantsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetOnHoldPlantsAsync(
                        facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                    break;
                }
            while (true);

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPlantAdditivesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetPlantAdditivesAsync(
                        facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                    break;
                }
            while (true);

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPlantAdditivesTypesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var plants =
                    sharedFixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetPlantAdditivesTypesAsync().Result);
                testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPlantWasteMethodsAllAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var plants = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Plants.GetPlantWasteMethodsAllAsync().Result);
                if (plants == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
                foreach (var plant in plants)
                    _additionalPropertiesHelper.CheckAdditionalProperties(plant, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPlantGrowthPhasesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var plants = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Plants.GetPlantGrowthPhasesAsync(facility.License.Number).Result);
                testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPlantWasteReasonsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var plants = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Plants.GetPlantWasteReasonsAsync(facility.License.Number).Result);
                if (plants == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
                foreach (var plant in plants)
                    _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetVegetativePlantsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetVegetativePlantsAsync(
                        facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                    break;
                }
            while (true);

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}