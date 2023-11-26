namespace OpenMetrc.V1;

public partial class MetrcService : IPackageClient
{
    [MapsToApi(MetrcEndpoint.get_packages_v1_id)]
    Task<Package> IPackageClient.GetPackageByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : PackageClient.GetPackageByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v1_id)]
    Task<Package> IPackageClient.GetPackageByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : PackageClient.GetPackageByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_label)]
    Task<Package> IPackageClient.GetPackageByLabelAsync(string label, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : PackageClient.GetPackageByLabelAsync(label, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v1_label)]
    Task<Package> IPackageClient.GetPackageByLabelAsync(string label, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : PackageClient.GetPackageByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    Task<ICollection<Package>?> IPackageClient.GetPackageActiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetPackageActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    Task<ICollection<Package>?> IPackageClient.GetPackageActiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetPackageActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    Task<ICollection<Package>?> IPackageClient.GetPackageOnHoldAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetPackageOnHoldAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    Task<ICollection<Package>?> IPackageClient.GetPackageOnHoldAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetPackageOnHoldAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    Task<ICollection<Package>?> IPackageClient.GetPackageInactiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetPackageInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    Task<ICollection<Package>?> IPackageClient.GetPackageInactiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetPackageInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_types)]
    Task<ICollection<string>> IPackageClient.GetPackageTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PackageClient.GetPackageTypesAsync();

    [MapsToApi(MetrcEndpoint.get_packages_v1_types)]
    Task<ICollection<string>> IPackageClient.GetPackageTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PackageClient.GetPackageTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_adjust_reasons)]
    Task<ICollection<PackageAdjustReason>?> IPackageClient.GetPackageAdjustReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PackageAdjustReason>?>(new List<PackageAdjustReason>())
            : PackageClient.GetPackageAdjustReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v1_adjust_reasons)]
    Task<ICollection<PackageAdjustReason>?> IPackageClient.GetPackageAdjustReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PackageAdjustReason>?>(new List<PackageAdjustReason>())
            : PackageClient.GetPackageAdjustReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    Task IPackageClient.PostPackageCreateAsync(string licenseNumber, IEnumerable<PostPackageCreateRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageCreateAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    Task IPackageClient.PostPackageCreateAsync(string licenseNumber, IEnumerable<PostPackageCreateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageCreateAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    Task IPackageClient.PostPackageCreateTestingAsync(string licenseNumber, IEnumerable<PostPackageCreateTestingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageCreateTestingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    Task IPackageClient.PostPackageCreateTestingAsync(string licenseNumber, IEnumerable<PostPackageCreateTestingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageCreateTestingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    Task IPackageClient.PostPackageCreatePlantingsAsync(string licenseNumber,
        IEnumerable<PostPackageCreatePlantingsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageCreatePlantingsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    Task IPackageClient.PostPackageCreatePlantingsAsync(string licenseNumber,
        IEnumerable<PostPackageCreatePlantingsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageCreatePlantingsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    Task IPackageClient.PostPackageChangeItemAsync(string licenseNumber, IEnumerable<PostPackageChangeItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageChangeItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    Task IPackageClient.PostPackageChangeItemAsync(string licenseNumber, IEnumerable<PostPackageChangeItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageChangeItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    Task IPackageClient.PutPackageChangeNoteAsync(string licenseNumber, IEnumerable<PutPackageChangeNoteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageChangeNoteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    Task IPackageClient.PutPackageChangeNoteAsync(string licenseNumber, IEnumerable<PutPackageChangeNoteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageChangeNoteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    Task IPackageClient.PostPackageChangeLocationsAsync(string licenseNumber,
        IEnumerable<PostPackageChangeLocationsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageChangeLocationsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    Task IPackageClient.PostPackageChangeLocationsAsync(string licenseNumber,
        IEnumerable<PostPackageChangeLocationsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageChangeLocationsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    Task IPackageClient.PostPackageAdjustAsync(string licenseNumber, IEnumerable<PostPackageAdjustRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageAdjustAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    Task IPackageClient.PostPackageAdjustAsync(string licenseNumber, IEnumerable<PostPackageAdjustRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageAdjustAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    Task IPackageClient.PostPackageFinishAsync(string licenseNumber, IEnumerable<PostPackageFinishRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageFinishAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    Task IPackageClient.PostPackageFinishAsync(string licenseNumber, IEnumerable<PostPackageFinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageFinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    Task IPackageClient.PostPackageUnfinishAsync(string licenseNumber, IEnumerable<PostPackageUnfinishRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageUnfinishAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    Task IPackageClient.PostPackageUnfinishAsync(string licenseNumber, IEnumerable<PostPackageUnfinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageUnfinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    Task IPackageClient.PostPackageRemediateAsync(string licenseNumber, IEnumerable<PostPackageRemediateRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageRemediateAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    Task IPackageClient.PostPackageRemediateAsync(string licenseNumber, IEnumerable<PostPackageRemediateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageRemediateAsync(licenseNumber, body, cancellationToken);
}