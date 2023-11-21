using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;
using System;

namespace OpenMetrc.Tests.V1.Services;

public class PlantBatchTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActivePlantBatchesAllAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var plantBatches = sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.PlantBatches.GetActivePlantBatchesAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (plantBatches == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || plantBatches.Any();
                        foreach (var plantBatch in plantBatches)
                            _additionalPropertiesHelper.CheckAdditionalProperties(plantBatch, facility.License.Number);
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
    public void GetInactivePlantBatchesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -2;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var plantBatches = sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.PlantBatches.GetInactivePlantBatchesAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (plantBatches == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || plantBatches.Any();
                        foreach (var plantBatch in plantBatches)
                            _additionalPropertiesHelper.CheckAdditionalProperties(plantBatch, facility.License.Number);

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
    public void GetPlantBatchTypesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var plantBatches = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.PlantBatches.GetPlantBatchTypesAsync().Result);
                testEndpointResult.WasTested = testEndpointResult.WasTested || plantBatches.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPlantBatchWasteReasonsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -2;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var plantBatches = sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.PlantBatches.GetPlantBatchWasteReasonsAsync(facility.License.Number)
                                .Result);
                        if (plantBatches == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || plantBatches.Any();
                        foreach (var plantBatch in plantBatches)
                            _additionalPropertiesHelper.CheckAdditionalProperties(plantBatch, facility.License.Number);

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