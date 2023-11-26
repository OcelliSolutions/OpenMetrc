namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PatientController : PatientsControllerBase
{
    /// <inheritdoc cref="PatientsControllerBase.GetPatientById" />
    [MapsToApi(MetrcEndpoint.get_patients_v1_id)]
    [ProducesResponseType(typeof(Patient), StatusCodes.Status200OK)]
    public override Task GetPatientById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PatientsControllerBase.GetPatientActive" />
    [MapsToApi(MetrcEndpoint.get_patients_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<Patient>), StatusCodes.Status200OK)]
    public override Task GetPatientActive(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientsControllerBase.PostPatientAdd" />
    [MapsToApi(MetrcEndpoint.post_patients_v1_add)]
    public override Task PostPatientAdd(
        [Required] List<PostPatientAddRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientsControllerBase.PostPatientUpdate" />
    [MapsToApi(MetrcEndpoint.post_patients_v1_update)]
    public override Task PostPatientUpdate(
        [Required] List<PostPatientUpdateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientsControllerBase.DeletePatientById" />
    [MapsToApi(MetrcEndpoint.delete_patients_v1_id)]
    public override Task DeletePatientById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}