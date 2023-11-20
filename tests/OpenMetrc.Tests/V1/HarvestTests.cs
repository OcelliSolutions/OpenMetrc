using OpenMetrc.V1;
using System;

namespace OpenMetrc.Tests.V1;

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
    public void GetActiveHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                        var cmd = Fixture.SafeExecutor(() => apiKey.MetrcService.Harvests.GetActiveHarvestsAsync(
                            facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);

                        if (facility.FacilityType.CanGrowPlants ?? false)
                        {
                            var harvests = cmd;
                            if (harvests == null) continue;
                            wasTested = wasTested || harvests.Any();
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
        Skip.IfNot(wasTested, "WARN: There were no active harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public void GetInactiveHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                        var cmd = Fixture.SafeExecutor(() => apiKey.MetrcService.Harvests.GetInactiveHarvestsAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);

                        if (facility.FacilityType.CanGrowPlants ?? false)
                        {
                            var harvests = cmd;
                            if (harvests == null) continue;
                            wasTested = wasTested || harvests.Any();
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
        Skip.IfNot(wasTested, "WARN: There were no inactive harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public void GetOnHoldHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                        var cmd = Fixture.SafeExecutor(() => apiKey.MetrcService.Harvests.GetOnHoldHarvestsAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);

                        if (facility.FacilityType.CanGrowPlants ?? false)
                        {
                            var harvests = cmd;
                            if (harvests == null) continue;
                            wasTested = wasTested || harvests.Any();
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
        Skip.IfNot(wasTested, "WARN: There were no on-hold harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public void GetHarvestWasteTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var cmd = Fixture.SafeExecutor(() => apiKey.MetrcService.Harvests.GetHarvestWasteTypesAsync().Result);

                if (cmd == null) continue;
                wasTested = wasTested || cmd.Any();
                foreach (var harvest in cmd)
                    _additionalPropertiesHelper.CheckAdditionalProperties(harvest, string.Empty);
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
        Skip.IfNot(wasTested, "WARN: There were no inactive harvests in the timespan selected for any license");
    }
}