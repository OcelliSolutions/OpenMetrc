namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class EmployeeController : EmployeesControllerBase
{
    /// <inheritdoc cref="EmployeesControllerBase.GetEmployees" />
    [MapsToApi(MetrcEndpoint.get_employees_v1)]
    [ProducesResponseType(typeof(IEnumerable<Employee>), StatusCodes.Status200OK)]
    public override Task GetEmployees(
        [Required] string licenseNumber) => Task.CompletedTask;
}