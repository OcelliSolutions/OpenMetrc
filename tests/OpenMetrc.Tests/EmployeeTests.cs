using System;

namespace OpenMetrc.Tests;

public class EmployeeTests : IAssemblyFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public EmployeeTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [Fact]
    public async void GetEmployeesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var employees = await apiKey.MetrcService.Employees.GetEmployeesAsync(facility.License.Number);
                wasTested = wasTested || employees.Any();
                foreach (var employee in employees)
                    _additionalPropertiesHelper.CheckAdditionalProperties(employee, facility.License.Number);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were testable brands for any license");
    }
}