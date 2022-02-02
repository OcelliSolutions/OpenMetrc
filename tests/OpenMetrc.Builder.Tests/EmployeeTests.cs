using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using OpenMetrc.Builder.Tests.Fixtures;
using OpenMetrc.Builder.Tests.Helpers;
using OpenMetrc.Common.Data;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Builder.Tests;

public class EmployeeTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;

    public EmployeeTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }

    private SharedFixture Fixture { get; }

    [Fact]
    public async void GetEmployeesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_employees_v1_, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
                try
                {
                    if (facility.IsOwner ?? false)
                    {
                        var employees = await apiKey.EmployeeClient.GetEmployeesAsync(facility.License.Number);
                        wasTested = wasTested || employees.Any();
                        foreach (var employee in employees)
                            _additionalPropertiesHelper.CheckAdditionalProperties(employee, facility.License.Number);
                    }
                    else
                    {
                        await Assert.ThrowsAsync<ApiException>(() =>
                            apiKey.EmployeeClient.GetEmployeesAsync(facility.License.Number));
                    }
                }
                catch (ApiException ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                    unauthorized++;
                }
        }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were testable brands for any license");
    }
}