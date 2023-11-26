namespace OpenMetrc.V1;

public partial class MetrcService : ILabTestClient
{
    [MapsToApi(MetrcEndpoint.get_labtests_v1_states)]
    Task<ICollection<string>> ILabTestClient.GetLabTestStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : LabTestClient.GetLabTestStatesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_types)]
    Task<ICollection<LabTestType>?> ILabTestClient.GetLabTestTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTestType>?>(new List<LabTestType>())
            : LabTestClient.GetLabTestTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_results)]
    Task<ICollection<LabTest>?> ILabTestClient.GetLabTestResultsAsync(long packageId, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTest>?>(new List<LabTest>())
            : LabTestClient.GetLabTestResultsAsync(packageId, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_labtests_v1_record)]
    Task ILabTestClient.PostLabTestRecordAsync(string licenseNumber, IEnumerable<PostLabTestRecordRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.PostLabTestRecordAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_labtestdocument)]
    Task ILabTestClient.PutLabTestLabTestDocumentAsync(string licenseNumber,
        IEnumerable<PutLabTestLabTestDocumentRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.PutLabTestLabTestDocumentAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_results_release)]
    Task ILabTestClient.PutLabTestResultReleaseAsync(string licenseNumber,
        IEnumerable<PutLabTestResultReleaseRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.PutLabTestResultReleaseAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_labtestdocument_id)]
    Task<ICollection<LabTest>?> ILabTestClient.GetLabTestLabTestDocumentByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTest>?>(new List<LabTest>())
            : LabTestClient.GetLabTestLabTestDocumentByIdAsync(id, licenseNumber, cancellationToken);
}