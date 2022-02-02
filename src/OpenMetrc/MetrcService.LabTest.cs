namespace OpenMetrc;

public partial class MetrcService : ILabTest
{
    [MapsToApi(MetrcEndpoint.get_labtests_v1_states)]
    Task<ICollection<string>> ILabTest.GetLabTestStatesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : MetrcClient.GetLabTestStatesAsync();

    [MapsToApi(MetrcEndpoint.get_labtests_v1_states)]
    Task<ICollection<string>> ILabTest.GetLabTestStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : MetrcClient.GetLabTestStatesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_types)]
    Task<ICollection<LabTestType>> ILabTest.GetLabTestTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTestType>>(new List<LabTestType>())
            : MetrcClient.GetLabTestTypesAsync();

    [MapsToApi(MetrcEndpoint.get_labtests_v1_types)]
    Task<ICollection<LabTestType>> ILabTest.GetLabTestTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTestType>>(new List<LabTestType>())
            : MetrcClient.GetLabTestTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_results)]
    Task<ICollection<LabTest>> ILabTest.GetLabTestResultsAsync(int packageId, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTest>>(new List<LabTest>())
            : MetrcClient.GetLabTestResultsAsync(packageId, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_results)]
    Task<ICollection<LabTest>> ILabTest.GetLabTestResultsAsync(int packageId, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTest>>(new List<LabTest>())
            : MetrcClient.GetLabTestResultsAsync(packageId, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_labtests_v1_record)]
    Task ILabTest.RecordLabTestAsync(string licenseNumber, IEnumerable<CreateLabTestResultRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.RecordLabTestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_labtests_v1_record)]
    Task ILabTest.RecordLabTestAsync(string licenseNumber, IEnumerable<CreateLabTestResultRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.RecordLabTestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_labtestdocument)]
    Task ILabTest.UpdateLabTestDocumentAsync(string licenseNumber, IEnumerable<UpdateLabTestDocumentRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateLabTestDocumentAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_labtestdocument)]
    Task ILabTest.UpdateLabTestDocumentAsync(string licenseNumber, IEnumerable<UpdateLabTestDocumentRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateLabTestDocumentAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_results_release)]
    Task ILabTest.ReleaseLabTestResultsAsync(string licenseNumber, IEnumerable<ReleaseLabTestResultsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.ReleaseLabTestResultsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_results_release)]
    Task ILabTest.ReleaseLabTestResultsAsync(string licenseNumber, IEnumerable<ReleaseLabTestResultsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.ReleaseLabTestResultsAsync(licenseNumber, body, cancellationToken);
}