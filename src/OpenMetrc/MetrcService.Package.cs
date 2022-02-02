namespace OpenMetrc;

public partial class MetrcService : IPackage
{
    [MapsToApi(MetrcEndpoint.get_packages_v1_id)]
    Task<Package> IPackage.GetPackageByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : MetrcClient.GetPackageByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v1_id)]
    Task<Package> IPackage.GetPackageByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : MetrcClient.GetPackageByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_label)]
    Task<Package> IPackage.GetPackageByLabelAsync(string label, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : MetrcClient.GetPackageByLabelAsync(label, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v1_label)]
    Task<Package> IPackage.GetPackageByLabelAsync(string label, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : MetrcClient.GetPackageByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    Task<ICollection<Package>> IPackage.GetActivePackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : MetrcClient.GetActivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    Task<ICollection<Package>> IPackage.GetActivePackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : MetrcClient.GetActivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    Task<ICollection<Package>> IPackage.GetOnHoldPackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : MetrcClient.GetOnHoldPackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    Task<ICollection<Package>> IPackage.GetOnHoldPackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : MetrcClient.GetOnHoldPackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    Task<ICollection<Package>> IPackage.GetInactivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : MetrcClient.GetInactivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    Task<ICollection<Package>> IPackage.GetInactivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : MetrcClient.GetInactivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_types)]
    Task<ICollection<string>> IPackage.GetPackageTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : MetrcClient.GetPackageTypesAsync();

    [MapsToApi(MetrcEndpoint.get_packages_v1_types)]
    Task<ICollection<string>> IPackage.GetPackageTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : MetrcClient.GetPackageTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_adjust_reasons)]
    Task<ICollection<PackageAdjustReason>> IPackage.GetPackageAdjustReasonsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PackageAdjustReason>>(new List<PackageAdjustReason>())
            : MetrcClient.GetPackageAdjustReasonsAsync();

    [MapsToApi(MetrcEndpoint.get_packages_v1_adjust_reasons)]
    Task<ICollection<PackageAdjustReason>> IPackage.GetPackageAdjustReasonsAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PackageAdjustReason>>(new List<PackageAdjustReason>())
            : MetrcClient.GetPackageAdjustReasonsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    Task IPackage.CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreatePackage2Async(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    Task IPackage.CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreatePackage2Async(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    Task IPackage.CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateTestingPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    Task IPackage.CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateTestingPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    Task IPackage.CreatePackagePlantingAsync(string licenseNumber, IEnumerable<CreatePackagePlantingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreatePackagePlantingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    Task IPackage.CreatePackagePlantingAsync(string licenseNumber, IEnumerable<CreatePackagePlantingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreatePackagePlantingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    Task IPackage.ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.ChangePackageItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    Task IPackage.ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.ChangePackageItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    Task IPackage.ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.ChangePackageNoteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    Task IPackage.ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.ChangePackageNoteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    Task IPackage.ChangePackageLocationAsync(string licenseNumber, IEnumerable<ChangePackageLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.ChangePackageLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    Task IPackage.ChangePackageLocationAsync(string licenseNumber, IEnumerable<ChangePackageLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.ChangePackageLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    Task IPackage.AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.AdjustPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    Task IPackage.AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.AdjustPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    Task IPackage.FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.FinishPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    Task IPackage.FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.FinishPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    Task IPackage.UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UnfinishPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    Task IPackage.UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UnfinishPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    Task IPackage.RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.RemediatePackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    Task IPackage.RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.RemediatePackageAsync(licenseNumber, body, cancellationToken);
}