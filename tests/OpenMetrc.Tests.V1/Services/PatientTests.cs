using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;

namespace OpenMetrc.Tests.V1.Services;

public class PatientTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActivePatientsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var patients = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Patients.GetActivePatientsAsync(facility.License.Number).Result);
                    if (patients == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || patients.Any();
                    foreach (var patient in patients)
                        _additionalPropertiesHelper.CheckAdditionalProperties(patient, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}