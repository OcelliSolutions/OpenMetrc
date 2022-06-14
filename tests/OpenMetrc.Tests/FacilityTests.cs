namespace OpenMetrc.Tests;

public class FacilityTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public FacilityTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public void GetFacilitiesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                wasTested = wasTested || apiKey.Facilities.Any();
                foreach (var facility in apiKey.Facilities)
                    _additionalPropertiesHelper.CheckAdditionalProperties(facility, facility.License.Number);
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
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    _testOutputHelper.WriteLine(ex.Response);
                    throw;
                }
                unauthorized++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.IfNot(wasTested, "WARN: No facilities were returned.");
    }
}