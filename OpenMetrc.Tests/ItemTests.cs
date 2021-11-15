using Microsoft.AspNetCore.Http;
using OpenMetrc.Client;
using OpenMetrc.Tests.Fixtures;
using System.Linq;
using System.Threading.Tasks;
using OpenMetrc.Common.Data;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Tests;

public class ItemTests : IClassFixture<SharedFixture>
{
    private readonly Helpers.AdditionalPropertiesHelper _additionalPropertiesHelper;
    private SharedFixture Fixture { get; }
    public ItemTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new Helpers.AdditionalPropertiesHelper(testOutputHelper);
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }

    [SkippableFact]
    public async void GetActiveItemsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_items_v1_active, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                var items = await apiKey.ItemClient.GetActiveItemsAsync(facility.License.Number);
                wasTested = wasTested || items.Any();
                foreach (var item in items)
                {
                    _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
                }
            }
        }
        Skip.IfNot(wasTested, "WARN: There were no active items for any license");
    }

    [SkippableFact]
    public async void GetItemBrandsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_items_v1_brands, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                try
                {
                    var items = await apiKey.ItemClient.GetItemBrandsAsync(facility.License.Number);
                    wasTested = wasTested || items.Any();
                    foreach (var item in items)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
                    }
                }
                catch (ApiException<ErrorResponse> ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                }
            }
        }
        Skip.IfNot(wasTested, "WARN: There were testable brands for any license");
    }
    [SkippableFact]
    public async void GetItemCategoriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_items_v1_categories, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                try
                {
                    var items = await apiKey.ItemClient.GetItemCategoriesAsync(facility.License.Number);
                    wasTested = wasTested || items.Any();
                    foreach (var item in items)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
                    }
                }
                catch (ApiException<ErrorResponse> ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                }
            }
        }
        Skip.IfNot(wasTested, "WARN: There were testable categories for any license");
    }
}
