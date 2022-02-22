using System.Diagnostics.CodeAnalysis;

namespace OpenMetrc.Builder.Controllers.V1;

[Route("employees/v1")]
[ApiController]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    [MapsToApi(MetrcEndpoint.get_employees_v1_)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageEmployees })]
    [ProducesResponseType(typeof(IEnumerable<Employee>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all employees for a license")]
    public ActionResult GetEmployees(
        [Required] [SwaggerParameter(Description = "The license must have `IsOwner` equal true.")]
        string licenseNumber) => Ok();
}