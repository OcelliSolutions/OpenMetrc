namespace OpenMetrc.V2;

public partial class MetrcService : IPatientClient
{
    [MapsToApi(MetrcEndpoint.get_patients_v2_id)]
    Task<Patient> IPatientClient.GetPatientByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Patient())
            : PatientClient.GetPatientByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_patients_v2_id)]
    Task<Patient> IPatientClient.GetPatientByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Patient())
            : PatientClient.GetPatientByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_patients_v2_id)]
    Task IPatientClient.DeletePatientByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.DeletePatientByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_patients_v2_id)]
    Task IPatientClient.DeletePatientByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.DeletePatientByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patients_v2_active)]
    Task<PatientMetrcWrapper> IPatientClient.GetPatientActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientMetrcWrapper())
            : PatientClient.GetPatientActiveAsync(licenseNumber, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_patients_v2_active)]
    Task<PatientMetrcWrapper> IPatientClient.GetPatientActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientMetrcWrapper())
            : PatientClient.GetPatientActiveAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patients_v2)]
    Task IPatientClient.PostPatientsAsync(string licenseNumber, IEnumerable<PostPatientsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.PostPatientsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_patients_v2)]
    Task IPatientClient.PostPatientsAsync(string licenseNumber, IEnumerable<PostPatientsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.PostPatientsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_patients_v2)]
    Task IPatientClient.PutPatientsAsync(string licenseNumber, IEnumerable<PutPatientsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.PutPatientsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_patients_v2)]
    Task IPatientClient.PutPatientsAsync(string licenseNumber, IEnumerable<PutPatientsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.PutPatientsAsync(licenseNumber, body, cancellationToken);
}