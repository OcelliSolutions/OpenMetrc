﻿using OpenMetrc.V1.Tests.Fixtures;

namespace OpenMetrc.V1.Tests.Services;

public class MetrcServiceTests(SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    [SkippableFact]
    public async Task MetrcClient_ChangeCredentials_ShouldCascade()
    {
        Skip.If(sharedFixture.ApiKeys.Count < 2, "WARN: At least two sample API Keys are required for this test.");

        var client0 = sharedFixture.ApiKeys[0];
        var client1 = sharedFixture.ApiKeys[1];
        var facilities0 = await client0.MetrcService.Facilities.GetFacilitiesAsync();

        client0.OpenMetrcConfig = client1.OpenMetrcConfig;

        //call the same client again with the new credentials
        var facilities1 = await client0.MetrcService.Facilities.GetFacilitiesAsync();

        //join all the license numbers together and ensure that you got separate results. 
        if (facilities0 == null || facilities1 == null) return;
        Assert.NotEqual(string.Join(",", facilities0.Select(f => f.License.Number).OrderBy(f => f)),
            string.Join(",", facilities1.Select(f => f.License.Number).OrderBy(f => f)));
    }
    /*
    /// <summary>
    ///     This number will change over time as new states are added and scraped by the `OpenMetrc.Scraper`.
    /// </summary>
    [Fact]
    public void MetrcClient_AvailableStates_NoNewStates()
    {
        var expectedStates = new List<string> {
            "ak", "al", "ar", "az", "ca", "co", "ct", "cz", "dc", "de", "fl", "ga", "gu", "hi", "ia", "id", "la", "ma", "md", "me", "mi", "mn", "mo", "ms", "mt", "nj", "nv", "oh", "ok",
            "or", "ri", "sd", "wv"
        };
        var actual = Fixture.ApiKeys[0].MetrcService.AvailableStates.ToList();
        Assert.Equal(expectedStates, actual);
    }
    */
}