using OpenMetrc.Common.Data;
using OpenMetrc.Tests.Fixtures;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace OpenMetrc.Tests;

public class EmployeeTests : IClassFixture<SharedFixture>
{
    private readonly Helpers.AdditionalPropertiesHelper _additionalPropertiesHelper;
    private SharedFixture Fixture { get; }
    public EmployeeTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new Helpers.AdditionalPropertiesHelper(testOutputHelper);
        Task.Run(() => Fixture.LoadFacilities()).Wait();
    }
    
    [Fact]
    public async void GetEmployeesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        foreach (var apiKey in Fixture.ApiKeys)
        {
            Assert.NotNull(apiKey);
            if (!Fixture.CheckEndpointAvailability(MetrcEndpoint.get_employees_v1_, apiKey)) continue;
            Assert.NotEmpty(apiKey.Facilities);
            foreach (var facility in apiKey.Facilities)
            {
                if (facility.IsOwner)
                {
                    var employees = await apiKey.EmployeeClient.GetEmployeesAsync(facility.License.Number);
                    foreach (var employee in employees)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(employee, facility.License.Number);
                    }
                }
                else
                    await Assert.ThrowsAsync<Client.ApiException<Client.ErrorResponse>>(() => apiKey.EmployeeClient.GetEmployeesAsync(facility.License.Number));
            }
        }
    }
}
