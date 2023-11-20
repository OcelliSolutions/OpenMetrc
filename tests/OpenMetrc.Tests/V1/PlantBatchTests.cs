using System;

namespace OpenMetrc.Tests.V1;

public class PlantBatchTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public PlantBatchTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public void GetActivePlantBatchesAllAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                        var plantBatches = Fixture.SafeExecutor(() =>
                            apiKey.MetrcService.PlantBatches.GetActivePlantBatchesAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (plantBatches == null) continue;
                        wasTested = wasTested || plantBatches.Any();
                        foreach (var plantBatch in plantBatches)
                            _additionalPropertiesHelper.CheckAdditionalProperties(plantBatch, facility.License.Number);
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
        Skip.IfNot(wasTested, "WARN: There were no testable PlantBatches for any license");
    }

    [SkippableFact]
    public void GetInactivePlantBatchesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -2;
        foreach (var apiKey in Fixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var plantBatches = Fixture.SafeExecutor(() =>
                            apiKey.MetrcService.PlantBatches.GetInactivePlantBatchesAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (plantBatches == null) continue;
                        wasTested = wasTested || plantBatches.Any();
                        foreach (var plantBatch in plantBatches)
                            _additionalPropertiesHelper.CheckAdditionalProperties(plantBatch, facility.License.Number);

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
        Skip.IfNot(wasTested, "WARN: There were no testable PlantBatches for any license");
    }

    [SkippableFact]
    public void GetPlantBatchTypesAsync_ValidEndpoint_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var plantBatches = Fixture.SafeExecutor(() => apiKey.MetrcService.PlantBatches.GetPlantBatchTypesAsync().Result);
                wasTested = wasTested || plantBatches.Any();
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
        Skip.IfNot(wasTested, "WARN: There were no testable PlantBatches for any license");
    }
}