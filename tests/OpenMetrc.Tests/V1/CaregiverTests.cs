using OpenMetrc.Tests;

namespace OpenMetrc.Tests.V1;

public class CaregiverTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public CaregiverTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public void GetCaregiversAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        //TODO: get sample caregiverLicenseNumbers
        var wasTested = false;
        var caregiverLicenseNumber = string.Empty;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var caregiverStatus = Fixture.SafeExecutor(() => apiKey.MetrcService.Caregivers.GetCaregiverStatusAsync(caregiverLicenseNumber, facility.License.Number).Result);
                    _additionalPropertiesHelper.CheckAdditionalProperties(caregiverStatus, facility.License.Number);
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
        Skip.IfNot(wasTested, "WARN: There were testable caregivers for any license");
    }
}