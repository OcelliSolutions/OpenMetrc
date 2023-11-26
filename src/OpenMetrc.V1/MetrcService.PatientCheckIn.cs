namespace OpenMetrc.V1;

public partial class MetrcService : IPatientCheckInClient
{
    [MapsToApi(MetrcEndpoint.get_patient_checkins_v1_locations)]
    Task<ICollection<PatientCheckInLocation>?> IPatientCheckInClient.GetPatientCheckInLocationsAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientCheckInLocation>?>(new List<PatientCheckInLocation>())
            : PatientCheckInClient.GetPatientCheckInLocationsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patient_checkins_v1)]
    Task<ICollection<PatientCheckIn>?> IPatientCheckInClient.GetPatientCheckInsAsync(string licenseNumber, DateOnly? checkinDateStart, DateOnly? checkinDateEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientCheckIn>?>(new List<PatientCheckIn>())
            : PatientCheckInClient.GetPatientCheckInsAsync(licenseNumber, checkinDateStart, checkinDateEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patient_checkins_v1)]
    Task IPatientCheckInClient.PostPatientCheckInsAsync(string licenseNumber, IEnumerable<PostPatientCheckInsRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.PostPatientCheckInsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_patient_checkins_v1)]
    Task IPatientCheckInClient.PutPatientCheckInsAsync(string licenseNumber, IEnumerable<PutPatientCheckInsRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.PutPatientCheckInsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_patient_checkins_v1_id)]
    Task IPatientCheckInClient.DeletePatientCheckInByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.DeletePatientCheckInByIdAsync(id, licenseNumber, cancellationToken);
}