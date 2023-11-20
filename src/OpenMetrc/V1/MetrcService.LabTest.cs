using OpenMetrc.V2;
using System.Threading;

namespace OpenMetrc.V1;

public partial class MetrcService : ILabTestClient
{
    [MapsToApi(MetrcEndpoint.get_labtests_v1_states)]
    Task<ICollection<string>> ILabTestClient.GetLabTestStatesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : LabTestClient.GetLabTestStatesAsync();

    [MapsToApi(MetrcEndpoint.get_labtests_v1_states)]
    Task<ICollection<string>> ILabTestClient.GetLabTestStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : LabTestClient.GetLabTestStatesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_types)]
    Task<ICollection<LabTestType>?> ILabTestClient.GetLabTestTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTestType>?>(new List<LabTestType>())
            : LabTestClient.GetLabTestTypesAsync();

    [MapsToApi(MetrcEndpoint.get_labtests_v1_types)]
    Task<ICollection<LabTestType>?> ILabTestClient.GetLabTestTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTestType>?>(new List<LabTestType>())
            : LabTestClient.GetLabTestTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_results)]
    Task<ICollection<LabTest>?> ILabTestClient.GetLabTestResultsAsync(long packageId, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTest>?>(new List<LabTest>())
            : LabTestClient.GetLabTestResultsAsync(packageId, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_results)]
    Task<ICollection<LabTest>?> ILabTestClient.GetLabTestResultsAsync(long packageId, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTest>?>(new List<LabTest>())
            : LabTestClient.GetLabTestResultsAsync(packageId, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_labtests_v1_record)]
    Task ILabTestClient.RecordLabTestAsync(string licenseNumber, IEnumerable<CreateLabTestResultRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.RecordLabTestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_labtests_v1_record)]
    Task ILabTestClient.RecordLabTestAsync(string licenseNumber, IEnumerable<CreateLabTestResultRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.RecordLabTestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_labtestdocument)]
    Task ILabTestClient.UpdateLabTestDocumentAsync(string licenseNumber,
        IEnumerable<UpdateLabTestDocumentRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.UpdateLabTestDocumentAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_labtestdocument)]
    Task ILabTestClient.UpdateLabTestDocumentAsync(string licenseNumber,
        IEnumerable<UpdateLabTestDocumentRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.UpdateLabTestDocumentAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_results_release)]
    Task ILabTestClient.ReleaseLabTestResultsAsync(string licenseNumber,
        IEnumerable<ReleaseLabTestResultsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.ReleaseLabTestResultsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_labtests_v1_results_release)]
    Task ILabTestClient.ReleaseLabTestResultsAsync(string licenseNumber,
        IEnumerable<ReleaseLabTestResultsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.ReleaseLabTestResultsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_labtestdocument_id)]
    public Task<ICollection<LabTest>?> GetLabTestDocumentAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTest>?>(new List<LabTest>())
            : LabTestClient.GetLabTestDocumentAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.get_labtests_v1_labtestdocument_id)]
    public Task<ICollection<LabTest>?> GetLabTestDocumentAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LabTest>?>(new List<LabTest>())
            : LabTestClient.GetLabTestDocumentAsync(licenseNumber, id, cancellationToken);
}