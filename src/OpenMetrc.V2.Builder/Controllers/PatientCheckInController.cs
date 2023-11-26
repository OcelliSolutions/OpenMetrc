namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PatientCheckInController : PatientCheckInsControllerBase
{
    /// <inheritdoc cref="PatientCheckInsControllerBase.GetPatientCheckInLocations" />
    [MapsToApi(MetrcEndpoint.get_patient_checkins_v2_locations)]
    [ProducesResponseType(typeof(MetrcWrapper<PatientCheckInLocation>), StatusCodes.Status200OK)]
    public override Task GetPatientCheckInLocations() => Task.CompletedTask;

    /// <inheritdoc cref="PatientCheckInsControllerBase.GetPatientCheckIns" />
    [MapsToApi(MetrcEndpoint.get_patient_checkins_v2)]
    [ProducesResponseType(typeof(MetrcWrapper<PatientCheckIn>), StatusCodes.Status200OK)]
    public override Task GetPatientCheckIns(
        [Required] string licenseNumber,
        DateTimeOffset? dateTimeOffset = null,
        DateTimeOffset? timeOffset = null) => Task.CompletedTask;

    /// <inheritdoc cref="PatientCheckInsControllerBase.PostPatientCheckIns" />
    [MapsToApi(MetrcEndpoint.post_patient_checkins_v2)]
    public override Task PostPatientCheckIns(
        [Required] [FromBody] List<PostPatientCheckInsRequest> createPatientCheckIns,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientCheckInsControllerBase.PutPatientCheckIns" />
    [MapsToApi(MetrcEndpoint.put_patient_checkins_v2)]
    public override Task PutPatientCheckIns(
        [Required] List<PutPatientCheckInsRequest> updatePatientCheckIns,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientCheckInsControllerBase.DeletePatientCheckInById" />
    [MapsToApi(MetrcEndpoint.delete_patient_checkins_v2_id)]
    public override Task DeletePatientCheckInById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}