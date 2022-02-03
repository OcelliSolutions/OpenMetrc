namespace OpenMetrc.Tests;

public class MetrcServiceTests : IClassFixture<SharedFixture>
{
    public MetrcServiceTests(SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public async Task MetrcClient_ChangeCredentials_ShouldCascade()
    {
        Skip.If(Fixture.ApiKeys.Count < 2, "WARN: At least two sample API Keys are required for this test.");

        var client0 = Fixture.ApiKeys[0];
        var client1 = Fixture.ApiKeys[1];
        var facilities0 = await client0.MetrcService.Facilities.GetFacilitiesAsync();

        client0.ClientKey = client1.ClientKey;
        client0.VendorKey = client1.VendorKey;
        client0.Domain = client1.Domain;

        //call the same client again with the new credentials
        var facilities1 = await client0.MetrcService.Facilities.GetFacilitiesAsync();

        //join all the license numbers together and ensure that you got separate results. 
        Assert.NotEqual(string.Join(",", facilities0.Select(f => f.License.Number).OrderBy(f => f)),
            string.Join(",", facilities1.Select(f => f.License.Number).OrderBy(f => f)));
    }
}