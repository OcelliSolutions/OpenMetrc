using System;

namespace OpenMetrc.Tests;

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
    public async void GetActiveStrainsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var strains = await apiKey.MetrcService.Strains.GetActiveStrainsAsync(facility.License.Number);
                if (strains == null) continue;
                wasTested = wasTested || strains.Any();
                foreach (var strain in strains)
                    _additionalPropertiesHelper.CheckAdditionalProperties(strain, facility.License.Number);
            }
            catch (ApiException<ErrorResponse?> ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized &&
                    ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                {
                    if (ex.Result != null) _testOutputHelper.WriteLine(ex.Result.Message);
                    _testOutputHelper.WriteLine(ex.Response);
                    throw;
                }

                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Strains for any license");
    }
}