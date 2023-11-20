using OpenMetrc.V1;
using System;

namespace OpenMetrc.Tests.V1;

public class HarvestTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActiveHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var cmd = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Harvests.GetActiveHarvestsAsync(
                        facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = cmd;
                        if (harvests == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        Assert.Throws<ApiException<ErrorResponse?>>(() => cmd);

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
    public void GetInactiveHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var cmd = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Harvests.GetInactiveHarvestsAsync(
                        facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = cmd;
                        if (harvests == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        Assert.Throws<ApiException<ErrorResponse?>>(() => cmd);

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
    public void GetOnHoldHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var cmd = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Harvests.GetOnHoldHarvestsAsync(
                        facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = cmd;
                        if (harvests == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        Assert.Throws<ApiException<ErrorResponse?>>(() => cmd);

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
    public void GetHarvestWasteTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var cmd = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Harvests.GetHarvestWasteTypesAsync().Result);

                if (cmd == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || cmd.Any();
                foreach (var harvest in cmd)
                    _additionalPropertiesHelper.CheckAdditionalProperties(harvest, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}