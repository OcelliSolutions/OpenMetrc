﻿namespace OpenMetrc.Tests;

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

        client0.UserApiKey = client1.UserApiKey;
        client0.SoftwareApiKey = client1.SoftwareApiKey;
        client0.SubDomain = client1.SubDomain;

        //call the same client again with the new credentials
        var facilities1 = await client0.MetrcService.Facilities.GetFacilitiesAsync();

        //join all the license numbers together and ensure that you got separate results. 
        Assert.NotEqual(string.Join(",", facilities0.Select(f => f.License.Number).OrderBy(f => f)),
            string.Join(",", facilities1.Select(f => f.License.Number).OrderBy(f => f)));
    }

    /// <summary>
    ///     This number will change over time as new states are added and scraped by the `OpenMetrc.Scraper`.
    /// </summary>
    [Fact]
    public void MetrcClient_AvailableStates_NoNewStates()
    {
        const int expected = 16;
        var actual = Fixture.ApiKeys[0].MetrcService.GetAvailableStates.Count();
        Assert.Equal(expected, actual);
    }
}