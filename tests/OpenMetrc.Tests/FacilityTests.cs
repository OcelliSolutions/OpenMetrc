using System.Threading.Tasks;
using OpenMetrc.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Tests;

public class FacilityTests : IClassFixture<SharedFixture>
{
    private readonly ITestOutputHelper _testOutputHelper;

    public FacilityTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }

    private SharedFixture Fixture { get; }

    [Fact]
    public void GetFacilitiesAsync_ShouldPass()
    {
        foreach (var apiKey in Fixture.ApiKeys) Assert.NotEmpty(apiKey.Facilities);
    }
}