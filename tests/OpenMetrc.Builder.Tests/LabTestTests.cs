using System.Linq;
using System.Threading.Tasks;
using OpenMetrc.Builder.Tests.Fixtures;
using OpenMetrc.Builder.Tests.Helpers;
using OpenMetrc.Common.Data;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Builder.Tests;

public class LabTestTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;

    public LabTestTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public async void GetLabTestTypesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_labtests_v1_types, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                var items = await apiKey.LabTestClient.GetLabTestTypesAsync();
                wasTested = wasTested || items.Any();
                foreach (var item in items)
                    _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
            }
        }

        Skip.IfNot(wasTested, "WARN: There were no testable lab test types for any license");
    }

    [SkippableFact]
    public async void GetLabTestStatesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_labtests_v1_states, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            var items = await apiKey.LabTestClient.GetLabTestStatesAsync();
            wasTested = wasTested || items.Any();
            Assert.NotEmpty(items);
        }

        Skip.IfNot(wasTested, "WARN: There were no testable lab test states for any license");
    }

    [Fact(Skip = "This is only testable with a valid package id that has test results")]
    public async void GetLabTestResultsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var packageId = 0;
        var wasTested = false;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_labtests_v1_results, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                var items = await apiKey.LabTestClient.GetLabTestResultsAsync(packageId, facility.License.Number);
                wasTested = wasTested || items.Any();
                foreach (var item in items)
                    _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
            }
        }

        Skip.IfNot(wasTested, "WARN: There were no testable lab test states for any license");
    }
}