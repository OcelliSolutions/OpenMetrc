using System;

namespace OpenMetrc.Tests;

public class PlantTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public PlantTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public void GetFloweringPlantsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetFloweringPlantsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    wasTested = wasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        break;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                        break;
                    }
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }

    [SkippableFact]
    public void GetInactivePlantsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetInactivePlantsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    wasTested = wasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        break;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                        break;
                    }
                }

            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }

    [SkippableFact]
    public void GetOnHoldPlantsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetOnHoldPlantsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    wasTested = wasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        break;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                        break;
                    }
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }

    [SkippableFact]
    public void GetPlantAdditivesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetPlantAdditivesAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    wasTested = wasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        break;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                        break;
                    }
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }

    [SkippableFact]
    public void GetPlantAdditivesTypesAsync_ValidEndpoint_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetPlantAdditivesTypesAsync().Result);
                wasTested = wasTested || plants.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }

    [SkippableFact]
    public void GetPlantWasteMethodsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetPlantWasteMethodsAsync().Result);
                if (plants == null) continue;
                wasTested = wasTested || plants.Any();
                foreach (var plant in plants)
                    _additionalPropertiesHelper.CheckAdditionalProperties(plant, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }

    [SkippableFact]
    public void GetPlantGrowthPhasesAsync_ValidEndpoint_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetPlantGrowthPhasesAsync(facility.License.Number).Result);
                wasTested = wasTested || plants.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }

    [SkippableFact]
    public void GetPlantWasteReasonsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetPlantWasteReasonsAsync(facility.License.Number).Result);
                if (plants == null) continue;
                wasTested = wasTested || plants.Any();
                foreach (var plant in plants)
                    _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }

    [SkippableFact]
    public void GetVegetativePlantsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var plants = Fixture.SafeExecutor(() => apiKey.MetrcService.Plants.GetVegetativePlantsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (plants == null) continue;
                    wasTested = wasTested || plants.Any();
                    foreach (var plant in plants)
                        _additionalPropertiesHelper.CheckAdditionalProperties(plant, facility.License.Number);
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        break;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                        break;
                    }
                }

            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Plants for any license");
    }
}