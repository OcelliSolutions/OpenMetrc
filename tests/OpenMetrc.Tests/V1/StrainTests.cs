using System;

namespace OpenMetrc.Tests.V1;

public class StrainTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public StrainTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public void GetActiveStrainsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var strains = Fixture.SafeExecutor(() => apiKey.MetrcService.Strains.GetActiveStrainsAsync(facility.License.Number).Result);
                    if (strains == null) continue;
                    wasTested = wasTested || strains.Any();
                    foreach (var strain in strains)
                        _additionalPropertiesHelper.CheckAdditionalProperties(strain, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        continue;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                    }
                }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Strains for any license");
    }
}