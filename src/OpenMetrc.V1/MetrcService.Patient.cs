namespace OpenMetrc.V1;

public partial class MetrcService : IPatientClient
{
    [MapsToApi(MetrcEndpoint.get_patients_v1_id)]
    Task<Patient> IPatientClient.GetPatientByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Patient())
            : PatientClient.GetPatientByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_patients_v1_id)]
    Task IPatientClient.DeletePatientByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.DeletePatientByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patients_v1_active)]
    Task<ICollection<Patient>?> IPatientClient.GetPatientActiveAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>?>(new List<Patient>())
            : PatientClient.GetPatientActiveAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patients_v1_add)]
    Task IPatientClient.PostPatientAddAsync(string licenseNumber, IEnumerable<PostPatientAddRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.PostPatientAddAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patients_v1_update)]
    Task IPatientClient.PostPatientUpdateAsync(string licenseNumber, IEnumerable<PostPatientUpdateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.PostPatientUpdateAsync(licenseNumber, body, cancellationToken);
}