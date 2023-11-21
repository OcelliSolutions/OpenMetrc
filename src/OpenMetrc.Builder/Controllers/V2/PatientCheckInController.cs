using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("patient-checkins/v2")]
[ApiVersion("2")]
[ApiController]
public class PatientCheckInController : ControllerBase
{
    [HttpGet("locations")]
    [MapsToApi(MetrcEndpoint.get_patientcheckins_v2_locations)]
    [Authorize]
    [ProducesResponseType(typeof(MetrcWrapper<PatientCheckInLocation>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all patient check-in locations")]
    public ActionResult GetPatientCheckInLocations() => Ok();

    [HttpGet]
    [MapsToApi(MetrcEndpoint.get_patientcheckins_v2)]
    [Authorize]
    [ProducesResponseType(typeof(MetrcWrapper<PatientCheckIn>), StatusCodes.Status200OK)]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePatientsCheckIns })]
    [SwaggerOperation(Summary = "Get all patient check-ins")]
    public ActionResult GetPatientCheckIns([Required] string licenseNumber,
        DateOnly? checkinDateStart,
        DateOnly? checkinDateEnd) => Ok();

    [HttpPost]
    [MapsToApi(MetrcEndpoint.post_patientcheckins_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePatientsCheckIns })]
    [SwaggerOperation(Summary = "Check in a patient")]
    public ActionResult CreatePatientCheckIn([Required] string licenseNumber,
        [Required, FromBody] List<CreatePatientCheckIn> createPatientCheckIns) => Ok();

    [HttpPut]
    [MapsToApi(MetrcEndpoint.put_patientcheckins_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePatientsCheckIns })]
    [SwaggerOperation(Summary = "Update a patient check in")]
    public ActionResult UpdatePatientCheckIn([Required] string licenseNumber,
        [Required, FromBody] List<UpdatePatientCheckIn> updatePatientCheckIns) => Ok();

    [HttpDelete("{id}")]
    [MapsToApi(MetrcEndpoint.delete_patientcheckins_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePatientsCheckIns })]
    [SwaggerOperation(Summary = "Update a patient check in")]
    public ActionResult DeletePatientCheckIn(
        [Required] long id,
        [Required] string licenseNumber) => Ok();
}