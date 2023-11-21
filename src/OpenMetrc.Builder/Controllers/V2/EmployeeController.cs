using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("employees/v2")]
[ApiVersion("2")]
[ApiController]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    [MapsToApi(MetrcEndpoint.get_employees_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ ApiPermission.ManageEmployees })]
    [ProducesResponseType(typeof(MetrcWrapper<Employee>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all employees for a license")]
    public ActionResult GetEmployees(
        [Required] [SwaggerParameter(Description = "The license must have `IsOwner` equal true.")]
        string licenseNumber) => Ok();
}