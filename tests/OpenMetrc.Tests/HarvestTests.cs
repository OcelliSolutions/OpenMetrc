using System;

namespace OpenMetrc.Tests;

[Collection("Api Key collection")]
public class HarvestTests
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;

    public HarvestTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public async void GetActiveHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var cmd = apiKey.MetrcService.Harvests.GetActiveHarvestsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(-1), null);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = await cmd;
                        wasTested = wasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        await Assert.ThrowsAsync<ApiException>(() => cmd);
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
        }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no active harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public async void GetInactiveHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var cmd = apiKey.MetrcService.Harvests.GetInactiveHarvestsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(-1), null);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = await cmd;
                        wasTested = wasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        await Assert.ThrowsAsync<ApiException>(() => cmd);
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
        }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no inactive harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public async void GetOnHoldHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var cmd = apiKey.MetrcService.Harvests.GetOnHoldHarvestsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(-1), null);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = await cmd;
                        wasTested = wasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        await Assert.ThrowsAsync<ApiException>(() => cmd);
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
        }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no on-hold harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public async void GetHarvestWasteTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                Assert.NotEmpty(apiKey.Facilities);
                var cmd = apiKey.MetrcService.Harvests.GetHarvestWasteTypesAsync();

                var harvests = await cmd;
                wasTested = wasTested || harvests.Any();
                foreach (var harvest in harvests)
                    _additionalPropertiesHelper.CheckAdditionalProperties(harvest, string.Empty);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no inactive harvests in the timespan selected for any license");
    }
}