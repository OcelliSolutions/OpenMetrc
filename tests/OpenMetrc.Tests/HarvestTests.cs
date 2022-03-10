using System;

namespace OpenMetrc.Tests;

public class HarvestTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

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
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var cmd = apiKey.MetrcService.Harvests.GetActiveHarvestsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = await cmd;
                        if (harvests == null) continue;
                        wasTested = wasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        await Assert.ThrowsAsync<ApiException<ErrorResponse?>>(() => cmd);

                    daysBack--;
                    if (daysBack < -10) break;
                }
                catch (ApiException<ErrorResponse?> ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized &&
                        ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                    {
                        if (ex.Result != null) _testOutputHelper.WriteLine(ex.Result.Message);
                        _testOutputHelper.WriteLine(ex.Response);
                        throw;
                    }

                    unauthorized++;
                }
                catch (TimeoutException)
                {
                    _testOutputHelper.WriteLine(
                        $@"{apiKey.OpenMetrcConfig.SubDomain}: {facility.License.Number}: Timeout");
                    timeout++;
                }

            while (true);

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
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var cmd = apiKey.MetrcService.Harvests.GetInactiveHarvestsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = await cmd;
                        if (harvests == null) continue;
                        wasTested = wasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        await Assert.ThrowsAsync<ApiException<ErrorResponse?>>(() => cmd);

                    daysBack--;
                    if (daysBack < -10) break;
                }
                catch (ApiException<ErrorResponse?> ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized &&
                        ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                    {
                        if (ex.Result != null) _testOutputHelper.WriteLine(ex.Result.Message);
                        _testOutputHelper.WriteLine(ex.Response);
                        throw;
                    }

                    unauthorized++;
                }
                catch (TimeoutException)
                {
                    _testOutputHelper.WriteLine(
                        $@"{apiKey.OpenMetrcConfig.SubDomain}: {facility.License.Number}: Timeout");
                    timeout++;
                }
            while (true);

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
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var cmd = apiKey.MetrcService.Harvests.GetOnHoldHarvestsAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null);

                    if (facility.FacilityType.CanGrowPlants ?? false)
                    {
                        var harvests = await cmd;
                        if (harvests == null) continue;
                        wasTested = wasTested || harvests.Any();
                        foreach (var harvest in harvests.Take(10))
                            _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                    else
                        await Assert.ThrowsAsync<ApiException<ErrorResponse?>>(() => cmd);

                    daysBack--;
                    if (daysBack < -10) break;
                }
                catch (ApiException<ErrorResponse?> ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized &&
                        ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                    {
                        if (ex.Result != null) _testOutputHelper.WriteLine(ex.Result.Message);
                        _testOutputHelper.WriteLine(ex.Response);
                        throw;
                    }

                    unauthorized++;
                }
                catch (TimeoutException)
                {
                    _testOutputHelper.WriteLine(
                        $@"{apiKey.OpenMetrcConfig.SubDomain}: {facility.License.Number}: Timeout");
                    timeout++;
                }
            while (true);

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
                var cmd = apiKey.MetrcService.Harvests.GetHarvestWasteTypesAsync();

                var harvests = await cmd;
                if (harvests == null) continue;
                wasTested = wasTested || harvests.Any();
                foreach (var harvest in harvests)
                    _additionalPropertiesHelper.CheckAdditionalProperties(harvest, string.Empty);
            }
            catch (ApiException<ErrorResponse?> ex)
            {
                if (ex.StatusCode == StatusCodes.Status401Unauthorized)
                {
                    if (ex.Result != null) _testOutputHelper.WriteLine(ex.Result.Message);
                    _testOutputHelper.WriteLine(ex.Response);
                    throw;
                }

                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no inactive harvests in the timespan selected for any license");
    }
}