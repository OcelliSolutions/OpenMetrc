using Microsoft.AspNetCore.Http;
using OpenMetrc.Client;
using OpenMetrc.Common.Data;
using OpenMetrc.Tests.Fixtures;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Tests;

public class LocationTests : IClassFixture<SharedFixture>
{
    private readonly Helpers.AdditionalPropertiesHelper _additionalPropertiesHelper;
    private SharedFixture Fixture { get; }
    public LocationTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new Helpers.AdditionalPropertiesHelper(testOutputHelper);
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }

    [SkippableFact]
    public async void GetActiveLocationsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_locations_v1_active, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                try
                {
                    var items = await apiKey.LocationClient.GetActiveLocationsAsync(facility.License.Number);
                    wasTested = wasTested || items.Any();
                    foreach (var item in items)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
                    }
                }
                catch (ApiException ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                    unauthorized++;
                }
            }
        }
        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable locations for any license");
    }

    [SkippableFact]
    public async void GetLocationTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_locations_v1_types, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                try
                {
                    var items = await apiKey.LocationClient.GetLocationTypesAsync(facility.License.Number);
                    wasTested = wasTested || items.Any();
                    foreach (var item in items)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
                    }
                }
                catch (ApiException ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                    unauthorized++;
                }
            }
        }
        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable location types for any license");
    }
}
