namespace OpenMetrc.V2;

public partial class MetrcService : IProcessingClient
{
    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_attributes)]
    Task<JobTypeAttributeMetrcWrapper> IProcessingClient.GetJobTypeAttributesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new JobTypeAttributeMetrcWrapper())
            : ProcessingClient.GetJobTypeAttributesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_attributes)]
    Task<JobTypeAttributeMetrcWrapper> IProcessingClient.GetJobTypeAttributesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new JobTypeAttributeMetrcWrapper())
            : ProcessingClient.GetJobTypeAttributesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_categories)]
    Task<StringMetrcWrapper> IProcessingClient.GetJobTypeCategoriesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : ProcessingClient.GetJobTypeCategoriesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_categories)]
    Task<StringMetrcWrapper> IProcessingClient.GetJobTypeCategoriesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : ProcessingClient.GetJobTypeCategoriesAsync(licenseNumber, cancellationToken);

    #region Processing

    [MapsToApi(MetrcEndpoint.get_processing_v2_id)]
    Task<Processing> IProcessingClient.GetProcessingByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Processing())
            : ProcessingClient.GetProcessingByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_processing_v2_id)]
    Task<Processing> IProcessingClient.GetProcessingByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Processing())
            : ProcessingClient.GetProcessingByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_processing_v2_id)]
    Task IProcessingClient.DeleteProcessingAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteProcessingAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_processing_v2_id)]
    Task IProcessingClient.DeleteProcessingAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteProcessingAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_active)]
    Task<ProcessingMetrcWrapper> IProcessingClient.GetActiveProcessingAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingMetrcWrapper())
            : ProcessingClient.GetActiveProcessingAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_processing_v2_active)]
    Task<ProcessingMetrcWrapper> IProcessingClient.GetActiveProcessingAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingMetrcWrapper())
            : ProcessingClient.GetActiveProcessingAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_inactive)]
    Task<ProcessingMetrcWrapper> IProcessingClient.GetInactiveProcessingAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingMetrcWrapper())
            : ProcessingClient.GetInactiveProcessingAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_processing_v2_inactive)]
    Task<ProcessingMetrcWrapper> IProcessingClient.GetInactiveProcessingAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingMetrcWrapper())
            : ProcessingClient.GetInactiveProcessingAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v2_createpackages)]
    Task IProcessingClient.CreateProcessingPackageAsync(string licenseNumber,
        IEnumerable<CreateProcessingPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.CreateProcessingPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_processing_v2_createpackages)]
    Task IProcessingClient.CreateProcessingPackageAsync(string licenseNumber,
        IEnumerable<CreateProcessingPackageRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.CreateProcessingPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v2_start)]
    Task IProcessingClient.StartProcessingAsync(string licenseNumber, IEnumerable<StartProcessingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.StartProcessingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_processing_v2_start)]
    Task IProcessingClient.StartProcessingAsync(string licenseNumber, IEnumerable<StartProcessingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.StartProcessingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v2_adjust)]
    Task IProcessingClient.AdjustProcessingAsync(string licenseNumber, IEnumerable<AdjustProcessingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.AdjustProcessingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_processing_v2_adjust)]
    Task IProcessingClient.AdjustProcessingAsync(string licenseNumber, IEnumerable<AdjustProcessingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.AdjustProcessingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v2_finish)]
    Task IProcessingClient.FinishProcessingAsync(string licenseNumber, IEnumerable<FinishProcessingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.FinishProcessingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_processing_v2_finish)]
    Task IProcessingClient.FinishProcessingAsync(string licenseNumber, IEnumerable<FinishProcessingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.FinishProcessingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v2_unfinish)]
    Task IProcessingClient.UnfinishProcessingAsync(string licenseNumber, IEnumerable<UnfinishProcessingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.UnfinishProcessingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_processing_v2_unfinish)]
    Task IProcessingClient.UnfinishProcessingAsync(string licenseNumber, IEnumerable<UnfinishProcessingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.UnfinishProcessingAsync(licenseNumber, body, cancellationToken);

    #endregion Processing

    #region Job Type

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_active)]
    Task<ProcessingJobTypeMetrcWrapper> IProcessingClient.GetActiveJobTypesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingJobTypeMetrcWrapper())
            : ProcessingClient.GetActiveJobTypesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_active)]
    Task<ProcessingJobTypeMetrcWrapper> IProcessingClient.GetActiveJobTypesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingJobTypeMetrcWrapper())
            : ProcessingClient.GetActiveJobTypesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_inactive)]
    Task<ProcessingJobTypeMetrcWrapper> IProcessingClient.GetInactiveJobTypesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingJobTypeMetrcWrapper())
            : ProcessingClient.GetInactiveJobTypesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_processing_v2_jobtypes_inactive)]
    Task<ProcessingJobTypeMetrcWrapper> IProcessingClient.GetInactiveJobTypesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ProcessingJobTypeMetrcWrapper())
            : ProcessingClient.GetInactiveJobTypesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_processing_v2_jobtypes)]
    Task IProcessingClient.CreateJobTypeAsync(string licenseNumber, IEnumerable<CreateJobTypeRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.CreateJobTypeAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_processing_v2_jobtypes)]
    Task IProcessingClient.CreateJobTypeAsync(string licenseNumber, IEnumerable<CreateJobTypeRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.CreateJobTypeAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_processing_v2_jobtypes)]
    Task IProcessingClient.UpdateJobTypeAsync(string licenseNumber, IEnumerable<ProcessingJobType>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.UpdateJobTypeAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_processing_v2_jobtypes)]
    Task IProcessingClient.UpdateJobTypeAsync(string licenseNumber, IEnumerable<ProcessingJobType>? body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.UpdateJobTypeAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_processing_v2_jobtypes_id)]
    Task IProcessingClient.DeleteJobTypeAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteJobTypeAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_processing_v2_jobtypes_id)]
    Task IProcessingClient.DeleteJobTypeAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ProcessingClient.DeleteJobTypeAsync(licenseNumber, id, cancellationToken);

    #endregion Job Type
}