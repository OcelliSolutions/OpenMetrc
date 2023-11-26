namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PatientCheckInController : PatientCheckInsControllerBase
{
    /// <inheritdoc cref="PatientCheckInsControllerBase.GetPatientCheckInLocations" />
    [MapsToApi(MetrcEndpoint.get_patient_checkins_v1_locations)]
    [ProducesResponseType(typeof(IEnumerable<PatientCheckInLocation>), StatusCodes.Status200OK)]
    public override Task GetPatientCheckInLocations() => Task.CompletedTask;

    /// <inheritdoc cref="PatientCheckInsControllerBase.GetPatientCheckIns" />
    [MapsToApi(MetrcEndpoint.get_patient_checkins_v1)]
    [ProducesResponseType(typeof(IEnumerable<PatientCheckIn>), StatusCodes.Status200OK)]
    public override Task GetPatientCheckIns([Required] string licenseNumber,
        DateOnly? checkinDateStart = null,
        DateOnly? checkinDateEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PatientCheckInsControllerBase.PostPatientCheckIns" />
    [MapsToApi(MetrcEndpoint.post_patient_checkins_v1)]
    public override Task PostPatientCheckIns(
        [Required] [FromBody] List<PostPatientCheckInsRequest> createPatientCheckIns,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientCheckInsControllerBase.PutPatientCheckIns" />
    [MapsToApi(MetrcEndpoint.put_patient_checkins_v1)]
    public override Task PutPatientCheckIns(
        [Required] List<PutPatientCheckInsRequest> updatePatientCheckIns,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientCheckInsControllerBase.DeletePatientCheckInById" />
    [MapsToApi(MetrcEndpoint.delete_patient_checkins_v1_id)]
    public override Task DeletePatientCheckInById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}