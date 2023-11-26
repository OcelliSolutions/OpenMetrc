namespace OpenMetrc.V1;

public partial class MetrcService : IProcessingClient
{
    #region Processing

    [MapsToApi(MetrcEndpoint.get_processing_v1_id)]
    Task<Processing> IProcessingClient.GetProcessingByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Processing())
            : ProcessingClient.GetProcessingByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_processing_v1_id)]
    Task<Processing> IProcessingClient.GetProcessingByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Processing())
            : ProcessingClient.GetProcessingByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_processing_v1_id)]
    Task IProcessingClient.DeleteProcessingByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteProcessingByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_processing_v1_id)]
    Task IProcessingClient.DeleteProcessingByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteProcessingByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v1_active)]
    Task<ICollection<Processing>?> IProcessingClient.GetProcessingActiveAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Processing>?>(new List<Processing>())
            : ProcessingClient.GetProcessingActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_processing_v1_active)]
    Task<ICollection<Processing>?> IProcessingClient.GetProcessingActiveAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Processing>?>(new List<Processing>())
            : ProcessingClient.GetProcessingActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v1_inactive)]
    Task<ICollection<Processing>?> IProcessingClient.GetProcessingInactiveAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Processing>?>(new List<Processing>())
            : ProcessingClient.GetProcessingInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_processing_v1_inactive)]
    Task<ICollection<Processing>?> IProcessingClient.GetProcessingInactiveAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Processing>?>(new List<Processing>())
            : ProcessingClient.GetProcessingInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v1_createpackages)]
    Task IProcessingClient.PostProcessingCreatePackagesAsync(string licenseNumber, IEnumerable<PostProcessingCreatePackagesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingCreatePackagesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_processing_v1_createpackages)]
    Task IProcessingClient.PostProcessingCreatePackagesAsync(string licenseNumber, IEnumerable<PostProcessingCreatePackagesRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingCreatePackagesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v1_start)]
    Task IProcessingClient.PostProcessingStartAsync(string licenseNumber, IEnumerable<PostProcessingStartRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingStartAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_processing_v1_start)]
    Task IProcessingClient.PostProcessingStartAsync(string licenseNumber, IEnumerable<PostProcessingStartRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingStartAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v1_adjust)]
    Task IProcessingClient.PostProcessingAdjustAsync(string licenseNumber, IEnumerable<PostProcessingAdjustRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingAdjustAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_processing_v1_adjust)]
    Task IProcessingClient.PostProcessingAdjustAsync(string licenseNumber, IEnumerable<PostProcessingAdjustRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingAdjustAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v1_finish)]
    Task IProcessingClient.PutProcessingFinishAsync(string licenseNumber, IEnumerable<PutProcessingFinishRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingFinishAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_processing_v1_finish)]
    Task IProcessingClient.PutProcessingFinishAsync(string licenseNumber, IEnumerable<PutProcessingFinishRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingFinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v1_unfinish)]
    Task IProcessingClient.PutProcessingUnfinishAsync(string licenseNumber, IEnumerable<PutProcessingUnfinishRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingUnfinishAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_processing_v1_unfinish)]
    Task IProcessingClient.PutProcessingUnfinishAsync(string licenseNumber, IEnumerable<PutProcessingUnfinishRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingUnfinishAsync(licenseNumber, body, cancellationToken);

    #endregion Processing

    #region Job Type

    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_active)]
    Task<ICollection<ProcessingJobType>?> IProcessingClient.GetProcessingJobTypeActiveAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ProcessingJobType>?>(new List<ProcessingJobType>())
            : ProcessingClient.GetProcessingJobTypeActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_active)]
    Task<ICollection<ProcessingJobType>?> IProcessingClient.GetProcessingJobTypeActiveAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ProcessingJobType>?>(new List<ProcessingJobType>())
            : ProcessingClient.GetProcessingJobTypeActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_inactive)]
    Task<ICollection<ProcessingJobType>?> IProcessingClient.GetProcessingJobTypeInactiveAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ProcessingJobType>?>(new List<ProcessingJobType>())
            : ProcessingClient.GetProcessingJobTypeInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_inactive)]
    Task<ICollection<ProcessingJobType>?> IProcessingClient.GetProcessingJobTypeInactiveAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ProcessingJobType>?>(new List<ProcessingJobType>())
            : ProcessingClient.GetProcessingJobTypeInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v1_jobtypes)]
    Task IProcessingClient.PostProcessingJobTypesAsync(string licenseNumber, IEnumerable<PostProcessingJobTypesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingJobTypesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_processing_v1_jobtypes)]
    Task IProcessingClient.PostProcessingJobTypesAsync(string licenseNumber, IEnumerable<PostProcessingJobTypesRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PostProcessingJobTypesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v1_jobtypes)]
    Task IProcessingClient.PutProcessingJobTypesAsync(string licenseNumber, IEnumerable<PutProcessingJobTypesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingJobTypesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_processing_v1_jobtypes)]
    Task IProcessingClient.PutProcessingJobTypesAsync(string licenseNumber, IEnumerable<PutProcessingJobTypesRequest> body, 
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.PutProcessingJobTypesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_processing_v1_jobtypes_id)]
    Task IProcessingClient.DeleteProcessingJobTypeByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
    ? Task.CompletedTask
            : ProcessingClient.DeleteProcessingJobTypeByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_processing_v1_jobtypes_id)]
    Task IProcessingClient.DeleteProcessingJobTypeByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteProcessingJobTypeByIdAsync(id, licenseNumber, cancellationToken);

    #endregion Job Type

    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_attributes)]
    Task<ICollection<JobTypeAttribute>?> IProcessingClient.GetProcessingJobTypeAttributesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<JobTypeAttribute>?>(new List<JobTypeAttribute>())
            : ProcessingClient.GetProcessingJobTypeAttributesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_attributes)]
    Task<ICollection<JobTypeAttribute>?> IProcessingClient.GetProcessingJobTypeAttributesAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<JobTypeAttribute>?>(new List<JobTypeAttribute>())
            : ProcessingClient.GetProcessingJobTypeAttributesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_categories)]
    Task<ICollection<string>> IProcessingClient.GetProcessingJobTypeCategoriesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : ProcessingClient.GetProcessingJobTypeCategoriesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_categories)]
    Task<ICollection<string>> IProcessingClient.GetProcessingJobTypeCategoriesAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : ProcessingClient.GetProcessingJobTypeCategoriesAsync(licenseNumber, cancellationToken);
}