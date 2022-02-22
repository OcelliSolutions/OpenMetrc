namespace OpenMetrc;

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
    Task<ICollection<Package>?> IPackageClient.GetActivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetActivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    Task<ICollection<Package>?> IPackageClient.GetActivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetActivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    Task<ICollection<Package>?> IPackageClient.GetOnHoldPackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetOnHoldPackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    Task<ICollection<Package>?> IPackageClient.GetOnHoldPackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetOnHoldPackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    Task<ICollection<Package>?> IPackageClient.GetInactivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetInactivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    Task<ICollection<Package>?> IPackageClient.GetInactivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>?>(new List<Package>())
            : PackageClient.GetInactivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
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
    Task IPackageClient.CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreatePackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    Task IPackageClient.CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreatePackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    Task IPackageClient.CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreateTestingPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    Task IPackageClient.CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreateTestingPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    Task IPackageClient.CreatePackagePlantingAsync(string licenseNumber,
        IEnumerable<CreatePackagePlantingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreatePackagePlantingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    Task IPackageClient.CreatePackagePlantingAsync(string licenseNumber,
        IEnumerable<CreatePackagePlantingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreatePackagePlantingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    Task IPackageClient.ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    Task IPackageClient.ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    Task IPackageClient.ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageNoteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    Task IPackageClient.ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageNoteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    Task IPackageClient.ChangePackageLocationAsync(string licenseNumber,
        IEnumerable<ChangePackageLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    Task IPackageClient.ChangePackageLocationAsync(string licenseNumber,
        IEnumerable<ChangePackageLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    Task IPackageClient.AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.AdjustPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    Task IPackageClient.AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.AdjustPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    Task IPackageClient.FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.FinishPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    Task IPackageClient.FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.FinishPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    Task IPackageClient.UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.UnfinishPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    Task IPackageClient.UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.UnfinishPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    Task IPackageClient.RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.RemediatePackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    Task IPackageClient.RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.RemediatePackageAsync(licenseNumber, body, cancellationToken);
}