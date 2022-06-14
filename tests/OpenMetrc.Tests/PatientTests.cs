using System;

namespace OpenMetrc.Tests;

public class PatientTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public PatientTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public void GetActivePatientsAllAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var patients = Fixture.SafeExecutor(() => apiKey.MetrcService.Patients.GetActivePatientsAsync(facility.License.Number).Result);
                if (patients == null) continue;
                wasTested = wasTested || patients.Any();
                foreach (var patient in patients)
                    _additionalPropertiesHelper.CheckAdditionalProperties(patient, facility.License.Number);
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
        Skip.IfNot(wasTested, "WARN: There were no testable Patients for any license");
    }
}