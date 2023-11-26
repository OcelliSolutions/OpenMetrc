using OpenMetrc.V1.Tests.Fixtures;
using OpenMetrc.V1.Tests.Helpers;

namespace OpenMetrc.V1.Tests.Services;

public class EmployeeTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetEmployeesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var employees = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Employees.GetEmployeesAsync(facility.License.Number).Result);
                    if (employees == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || employees.Any();
                    foreach (var employee in employees)
                        _additionalPropertiesHelper.CheckAdditionalProperties(employee, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}