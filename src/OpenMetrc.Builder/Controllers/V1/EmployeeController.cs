using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V1;

[Route("employees/v1")]
[ApiVersion("1")]
[ApiController]
public class EmployeeController : EmployeesControllerBase
{
    // <inheritDoc />
    [HttpGet]
    [MapsToApi(MetrcEndpoint.get_employees_v1)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageEmployees })]
    [ProducesResponseType(typeof(IEnumerable<Employee>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all employees for a license")]
    public override Task GetEmployees([Required] string licenseNumber) => throw new NotImplementedException();
}