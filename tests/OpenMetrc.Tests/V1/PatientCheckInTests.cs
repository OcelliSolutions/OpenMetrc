namespace OpenMetrc.Tests.V1;

public class PatientCheckInTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetPatientCheckInsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var patientCheckIns = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.PatientCheckIns.GetPatientCheckInsAsync(facility.License.Number, null, null)
                        .Result);
                if (patientCheckIns == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || patientCheckIns.Any();
                foreach (var patientCheckIn in patientCheckIns)
                    _additionalPropertiesHelper.CheckAdditionalProperties(patientCheckIn, facility.License.Number);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPatientCheckInLocationsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var patientCheckIns = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.PatientCheckIns.GetPatientCheckInLocationsAsync().Result);
                if (patientCheckIns == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || patientCheckIns.Any();
                foreach (var patientCheckIn in patientCheckIns)
                    _additionalPropertiesHelper.CheckAdditionalProperties(patientCheckIn, facility.License.Number);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}