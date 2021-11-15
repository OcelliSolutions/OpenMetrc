using OpenMetrc.Tests.Fixtures;
using System;
using System.Linq;
using System.Threading.Tasks;
using OpenMetrc.Common.Data;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Tests;

public class HarvestTests : IClassFixture<SharedFixture>
{
    private readonly Helpers.AdditionalPropertiesHelper _additionalPropertiesHelper;
    public HarvestTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new Helpers.AdditionalPropertiesHelper(testOutputHelper);
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }

    private SharedFixture Fixture { get; }
    
    [SkippableFact]
    public async void GetActiveHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_harvests_v1_active, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                var cmd = apiKey.HarvestClient.GetActiveHarvestsAsync(facility.License.Number, DateTimeOffset.UtcNow.AddDays(-1), null);

                if (facility.FacilityType.CanGrowPlants ?? false)
                {
                    var harvests = await cmd;
                    wasTested = wasTested || harvests.Any();
                    foreach (var harvest in harvests.Take(10))
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                }
                else
                {
                    await Assert.ThrowsAsync<Client.ApiException<Client.ErrorResponse>>(() => cmd);
                }
            }
        }
        Skip.IfNot(wasTested, "WARN: There were no active harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public async void GetInactiveHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_harvests_v1_inactive, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                var cmd = apiKey.HarvestClient.GetInactiveHarvestsAsync(facility.License.Number, DateTimeOffset.UtcNow.AddDays(-1), null);

                if (facility.FacilityType.CanGrowPlants ?? false)
                {
                    var harvests = await cmd;
                    wasTested = wasTested || harvests.Any();
                    foreach (var harvest in harvests.Take(10))
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                }
                else
                {
                    await Assert.ThrowsAsync<Client.ApiException<Client.ErrorResponse>>(() => cmd);
                }
            }
        }
        Skip.IfNot(wasTested, "WARN: There were no inactive harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public async void GetOnHoldHarvestsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_harvests_v1_onhold, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                var cmd = apiKey.HarvestClient.GetOnHoldHarvestsAsync(facility.License.Number, DateTimeOffset.UtcNow.AddDays(-1), null);

                if (facility.FacilityType.CanGrowPlants ?? false)
                {
                    var harvests = await cmd;
                    wasTested = wasTested || harvests.Any();
                    foreach (var harvest in harvests.Take(10))
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(harvest, facility.License.Number);
                    }
                }
                else
                {
                    await Assert.ThrowsAsync<Client.ApiException<Client.ErrorResponse>>(() => cmd);
                }
            }
        }
        Skip.IfNot(wasTested, "WARN: There were no on-hold harvests in the timespan selected for any license");
    }

    [SkippableFact]
    public async void GetHarvestWasteTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_harvests_v1_waste_types, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            var cmd = apiKey.HarvestClient.GetHarvestWasteTypesAsync();

            var harvests = await cmd;
            wasTested = wasTested || harvests.Any();
            foreach (var harvest in harvests)
            {
                _additionalPropertiesHelper.CheckAdditionalProperties(harvest, string.Empty);
            }
        }

        Skip.IfNot(wasTested, "WARN: There were no inactive harvests in the timespan selected for any license");
    }
}
