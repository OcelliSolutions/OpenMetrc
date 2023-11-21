using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("caregivers/v2")]
[ApiVersion("2")]
[ApiController]
public class CaregiverController : ControllerBase
{
    [HttpGet("status/{caregiverLicenseNumber}")]
    [MapsToApi(MetrcEndpoint.get_caregivers_v2_status_caregiverLicenseNumber)]
    [Authorize]
    [ApiAuthorizationFilter( new []{ ApiPermission.LookupCaregivers })]
    [ProducesResponseType(typeof(CaregiverStatus), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Data returned by this endpoint is cached for up to one minute")]
    public ActionResult GetCaregiverStatus(
        [Required] [SwaggerParameter(Description = "The license number of the Caregiver.")] string caregiverLicenseNumber,
        [Required] [SwaggerParameter(Description = "The license number of the Facility under which to get the Caregiver status.")]
        string licenseNumber) => Ok();
}