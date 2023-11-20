using OpenMetrc.V1;

namespace OpenMetrc.Tests.V1;

public class FacilityTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetFacilitiesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();

        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                testEndpointResult.WasTested = testEndpointResult.WasTested || apiKey.Facilities.Any();
                foreach (var facility in apiKey.Facilities)
                    _additionalPropertiesHelper.CheckAdditionalProperties(facility, facility.License.Number);
            }
            catch (ApiException<ErrorResponse?> ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized &&
                    ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                {
                    if (ex.Result != null) testOutputHelper.WriteLine(ex.Result.Message);
                    testOutputHelper.WriteLine(ex.Response);
                    throw;
                }

                testEndpointResult.Unauthorized++;
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                {
                    testOutputHelper.WriteLine(ex.Message);
                    testOutputHelper.WriteLine(ex.Response);
                    throw;
                }

                testEndpointResult.Unauthorized++;
            }

        Skip.If(!testEndpointResult.WasTested && testEndpointResult.Unauthorized > 0,
            "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.IfNot(testEndpointResult.WasTested, "WARN: No facilities were returned.");
    }
}