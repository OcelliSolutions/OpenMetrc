using OpenMetrc.Tests.Fixtures;
using System.Threading.Tasks;
using OpenMetrc.Common.Data;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Tests;

public class FacilityTests : IClassFixture<SharedFixture>
{
    private readonly Helpers.AdditionalPropertiesHelper _additionalPropertiesHelper;
    public FacilityTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new Helpers.AdditionalPropertiesHelper(testOutputHelper);
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }

    private SharedFixture Fixture { get; }

    [Fact]
    public void GetFacilitiesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_facilities_v1_, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                _additionalPropertiesHelper.CheckAdditionalProperties(facility, facility.License.Number);
            }
        }
    }
}
