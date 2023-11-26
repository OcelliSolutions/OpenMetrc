namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PatientController : PatientsControllerBase
{
    /// <inheritdoc cref="PatientsControllerBase.GetPatientById" />
    [MapsToApi(MetrcEndpoint.get_patients_v2_id)]
    [ProducesResponseType(typeof(Patient), StatusCodes.Status200OK)]
    public override Task GetPatientById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PatientsControllerBase.GetPatientActive" />
    [MapsToApi(MetrcEndpoint.get_patients_v2_active)]
    [ProducesResponseType(typeof(MetrcWrapper<Patient>), StatusCodes.Status200OK)]
    public override Task GetPatientActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="PatientsControllerBase.PostPatients" />
    [MapsToApi(MetrcEndpoint.post_patients_v2)]
    public override Task PostPatients(
        [Required] List<PostPatientsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientsControllerBase.PutPatients" />
    [MapsToApi(MetrcEndpoint.put_patients_v2)]
    public override Task PutPatients(
        [Required] List<PutPatientsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PatientsControllerBase.DeletePatientById" />
    [MapsToApi(MetrcEndpoint.delete_patients_v2_id)]
    public override Task DeletePatientById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}