namespace OpenMetrc.V2;

public partial class MetrcService : IPatientCheckInClient
{
    [MapsToApi(MetrcEndpoint.get_patient_checkins_v2_locations)]
    Task<PatientCheckInLocationMetrcWrapper> IPatientCheckInClient.GetPatientCheckInLocationsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientCheckInLocationMetrcWrapper())
            : PatientCheckInClient.GetPatientCheckInLocationsAsync();

    [MapsToApi(MetrcEndpoint.get_patient_checkins_v2_locations)]
    Task<PatientCheckInLocationMetrcWrapper> IPatientCheckInClient.GetPatientCheckInLocationsAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientCheckInLocationMetrcWrapper())
            : PatientCheckInClient.GetPatientCheckInLocationsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patient_checkins_v2)]
    Task<PatientCheckInMetrcWrapper> IPatientCheckInClient.GetPatientCheckInsAsync(string licenseNumber,
        DateTimeOffset? checkinDateStart, DateTimeOffset? checkinDateEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientCheckInMetrcWrapper())
            : PatientCheckInClient.GetPatientCheckInsAsync(licenseNumber, checkinDateStart, checkinDateEnd);

    [MapsToApi(MetrcEndpoint.get_patient_checkins_v2)]
    Task<PatientCheckInMetrcWrapper> IPatientCheckInClient.GetPatientCheckInsAsync(string licenseNumber,
        DateTimeOffset? checkinDateStart, DateTimeOffset? checkinDateEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientCheckInMetrcWrapper())
            : PatientCheckInClient.GetPatientCheckInsAsync(licenseNumber, checkinDateStart, checkinDateEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patient_checkins_v2)]
    Task IPatientCheckInClient.PostPatientCheckInsAsync(string licenseNumber,
        IEnumerable<PostPatientCheckInsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.PostPatientCheckInsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_patient_checkins_v2)]
    Task IPatientCheckInClient.PostPatientCheckInsAsync(string licenseNumber,
        IEnumerable<PostPatientCheckInsRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.PostPatientCheckInsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_patient_checkins_v2)]
    Task IPatientCheckInClient.PutPatientCheckInsAsync(string licenseNumber, IEnumerable<PutPatientCheckInsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.PutPatientCheckInsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_patient_checkins_v2)]
    Task IPatientCheckInClient.PutPatientCheckInsAsync(string licenseNumber, IEnumerable<PutPatientCheckInsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.PutPatientCheckInsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_patient_checkins_v2_id)]
    Task IPatientCheckInClient.DeletePatientCheckInByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.DeletePatientCheckInByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_patient_checkins_v2_id)]
    Task IPatientCheckInClient.DeletePatientCheckInByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.DeletePatientCheckInByIdAsync(id, licenseNumber, cancellationToken);
}