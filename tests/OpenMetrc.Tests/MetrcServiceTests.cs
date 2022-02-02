using System.Threading.Tasks;
using OpenMetrc.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Tests;

public class MetrcServiceTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public MetrcServiceTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        _testOutputHelper = testOutputHelper;
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }

    private SharedFixture Fixture { get; }

    [Fact]
    public void MetrcClient_ChangeCredentials_ShouldCascade()
    {
        //Arrange
        //var client = new MetrcService(new Client(new HttpClient()), "co", "software", "user", false, true);
        //client.State = "ak";
        //_testOutputHelper.WriteLine(client.State);
        //var f = client.Facilities.GetFacilitiesAsync().Result;
        //Act 
        //_testOutputHelper.WriteLine(f.Count.ToString());
        //Assert
    }
}