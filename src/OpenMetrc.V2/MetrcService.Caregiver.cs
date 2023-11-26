namespace OpenMetrc.V2;

public partial class MetrcService : ICaregiverClient
{
    [MapsToApi(MetrcEndpoint.get_caregivers_v2_status_caregiverLicenseNumber)]
    Task<CaregiverStatus> ICaregiverClient.
        GetCaregiverStatusAsync(string caregiverLicenseNumber, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new CaregiverStatus())
            : CaregiverClient.GetCaregiverStatusAsync(caregiverLicenseNumber, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_caregivers_v2_status_caregiverLicenseNumber)]
    Task<CaregiverStatus> ICaregiverClient.GetCaregiverStatusAsync(string caregiverLicenseNumber, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new CaregiverStatus())
            : CaregiverClient.GetCaregiverStatusAsync(caregiverLicenseNumber, licenseNumber, cancellationToken);
}