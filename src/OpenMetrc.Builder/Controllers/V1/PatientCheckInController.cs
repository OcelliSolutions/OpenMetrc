using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V1;

[Route("patient-checkins/v1")]
[ApiVersion("1")]
[ApiController]
public class PatientCheckInController : ControllerBase
{
    [HttpGet("locations")]
    [MapsToApi(MetrcEndpoint.get_patientcheckins_v1_locations)]
    [Authorize]
    [ProducesResponseType(typeof(IEnumerable<PatientCheckInLocation>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all patient check-in locations")]
    public ActionResult GetPatientCheckInLocations() => Ok();

    [HttpGet]
    [MapsToApi(MetrcEndpoint.get_patientcheckins_v1)]
    [Authorize]
    [ProducesResponseType(typeof(IEnumerable<PatientCheckIn>), StatusCodes.Status200OK)]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePatientsCheckIns })]
    [SwaggerOperation(Summary = "Get all patient check-ins")]
    public ActionResult GetPatientCheckIns([Required] string licenseNumber,
        DateOnly? checkinDateStart,
        DateOnly? checkinDateEnd) => Ok();

    [HttpPost]
    [MapsToApi(MetrcEndpoint.post_patientcheckins_v1)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePatientsCheckIns })]
    [SwaggerOperation(Summary = "Check in a patient")]
    public ActionResult CreatePatientCheckIn([Required] string licenseNumber,
        [Required, FromBody] List<CreatePatientCheckIn> createPatientCheckIns) => Ok();

    [HttpPut]
    [MapsToApi(MetrcEndpoint.put_patientcheckins_v1)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePatientsCheckIns })]
    [SwaggerOperation(Summary = "Update a patient check in")]
    public ActionResult UpdatePatientCheckIn([Required] string licenseNumber,
        [Required, FromBody] List<UpdatePatientCheckIn> updatePatientCheckIns) => Ok();

    [HttpDelete("{id}")]
    [MapsToApi(MetrcEndpoint.delete_patientcheckins_v1_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePatientsCheckIns })]
    [SwaggerOperation(Summary = "Update a patient check in")]
    public ActionResult DeletePatientCheckIn(
        [Required] long id,
        [Required] string licenseNumber) => Ok();
}