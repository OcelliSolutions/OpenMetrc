namespace OpenMetrc.V2;

public partial class MetrcService : IProcessingClient
{
    #region Processing

    [MapsToApi(MetrcEndpoint.get_processing_v2_id)]
    Task<Processing> IProcessingClient.GetProcessingByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Processing())
            : ProcessingClient.GetProcessingByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_processing_v2_id)]
    Task IProcessingClient.DeleteProcessingByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteProcessingByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_active)]
    Task<ProcessingMetrcWrapper> IProcessingClient.GetProcessingActiveAsync(string licenseNumber, int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingMetrcWrapper())
            : ProcessingClient.GetProcessingActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_inactive)]
    Task<ProcessingMetrcWrapper> IProcessingClient.GetProcessingInactiveAsync(string licenseNumber, int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingMetrcWrapper())
            : ProcessingClient.GetProcessingInactiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v2_createpackages)]
    Task IProcessingClient.PostProcessingCreatePackagesAsync(string licenseNumber,
        IEnumerable<PostProcessingCreatePackagesRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingCreatePackagesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v2_start)]
    Task IProcessingClient.PostProcessingStartAsync(string licenseNumber, IEnumerable<PostProcessingStartRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingStartAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v2_adjust)]
    Task IProcessingClient.PostProcessingAdjustAsync(string licenseNumber, IEnumerable<PostProcessingAdjustRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingAdjustAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v2_finish)]
    Task IProcessingClient.PutProcessingFinishAsync(string licenseNumber, IEnumerable<PutProcessingFinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingFinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v2_unfinish)]
    Task IProcessingClient.PutProcessingUnfinishAsync(string licenseNumber, IEnumerable<PutProcessingUnfinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingUnfinishAsync(licenseNumber, body, cancellationToken);

    #endregion Processing

    #region Job Type

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_active)]
    Task<ProcessingJobTypeMetrcWrapper> IProcessingClient.GetProcessingJobTypeActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingJobTypeMetrcWrapper())
            : ProcessingClient.GetProcessingJobTypeActiveAsync(licenseNumber, pageNumber, pageSize,
                lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_inactive)]
    Task<ProcessingJobTypeMetrcWrapper> IProcessingClient.GetProcessingJobTypeInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingJobTypeMetrcWrapper())
            : ProcessingClient.GetProcessingJobTypeInactiveAsync(licenseNumber, pageNumber, pageSize,
                lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v2_jobtypes)]
    Task IProcessingClient.PostProcessingJobTypesAsync(string licenseNumber, IEnumerable<PostProcessingJobTypesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingJobTypesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v2_jobtypes)]
    Task IProcessingClient.PutProcessingJobTypesAsync(string licenseNumber, IEnumerable<PutProcessingJobTypesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingJobTypesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_processing_v2_jobtypes_id)]
    Task IProcessingClient.DeleteProcessingJobTypeByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteProcessingJobTypeByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_attributes)]
    Task<JobTypeAttributeMetrcWrapper> IProcessingClient.GetProcessingJobTypeAttributesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new JobTypeAttributeMetrcWrapper())
            : ProcessingClient.GetProcessingJobTypeAttributesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_categories)]
    Task<StringMetrcWrapper> IProcessingClient.GetProcessingJobTypeCategoriesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : ProcessingClient.GetProcessingJobTypeCategoriesAsync(licenseNumber, cancellationToken);

    #endregion Job Type
}