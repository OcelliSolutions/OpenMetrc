using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V1;

[Route("caregivers/v1")]
[ApiVersion("1")]
[ApiController]
public class CaregiverController : ControllerBase
{
    [HttpGet("status/{caregiverLicenseNumber}")]
    [MapsToApi(MetrcEndpoint.get_caregivers_v1_status_caregiverLicenseNumber)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.LookupCaregivers })]
    [ProducesResponseType(typeof(CaregiverStatus), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Data returned by this endpoint is cached for up to one minute")]
    public ActionResult GetCaregiverStatus(
        [Required] [SwaggerParameter(Description = "The license number of the Caregiver.")] string caregiverLicenseNumber,
        [Required] [SwaggerParameter(Description = "The license number of the Facility under which to get the Caregiver status.")]
        string licenseNumber) => Ok();
}