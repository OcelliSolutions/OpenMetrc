using System;

namespace OpenMetrc.Tests;

public class PlantBatchTests : IAssemblyFixture<SharedFixture>
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
    public async void GetActivePlantBatchesAllAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var plantBatches =
                    await apiKey.MetrcService.PlantBatches.GetActivePlantBatchesAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(-1), null);
                wasTested = wasTested || plantBatches.Any();
                foreach (var plantBatch in plantBatches)
                    _additionalPropertiesHelper.CheckAdditionalProperties(plantBatch, facility.License.Number);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable PlantBatches for any license");
    }

    [SkippableFact]
    public async void GetInactivePlantBatchesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var plantBatches =
                    await apiKey.MetrcService.PlantBatches.GetInactivePlantBatchesAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(-1), null);
                wasTested = wasTested || plantBatches.Any();
                foreach (var plantBatch in plantBatches)
                    _additionalPropertiesHelper.CheckAdditionalProperties(plantBatch, facility.License.Number);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable PlantBatches for any license");
    }

    [SkippableFact]
    public async void GetPlantBatchTypesAsync_ValidEndpoint_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var plantBatches = await apiKey.MetrcService.PlantBatches.GetPlantBatchTypesAsync();
                wasTested = wasTested || plantBatches.Any();
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable PlantBatches for any license");
    }
}