namespace OpenMetrc;

public partial class MetrcService : IPackage
{
    [MapsToApi(MetrcEndpoint.get_packages_v1_id)]
    Task<Package> IPackage.GetPackageByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : UserMetrcClient.GetPackageByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v1_id)]
    Task<Package> IPackage.GetPackageByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : UserMetrcClient.GetPackageByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_label)]
    Task<Package> IPackage.GetPackageByLabelAsync(string label, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : UserMetrcClient.GetPackageByLabelAsync(label, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v1_label)]
    Task<Package> IPackage.GetPackageByLabelAsync(string label, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : UserMetrcClient.GetPackageByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    Task<ICollection<Package>> IPackage.GetActivePackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : UserMetrcClient.GetActivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    Task<ICollection<Package>> IPackage.GetActivePackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : UserMetrcClient.GetActivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    Task<ICollection<Package>> IPackage.GetOnHoldPackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : UserMetrcClient.GetOnHoldPackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    Task<ICollection<Package>> IPackage.GetOnHoldPackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : UserMetrcClient.GetOnHoldPackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    Task<ICollection<Package>> IPackage.GetInactivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : UserMetrcClient.GetInactivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    Task<ICollection<Package>> IPackage.GetInactivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Package>>(new List<Package>())
            : UserMetrcClient.GetInactivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_types)]
    Task<ICollection<string>> IPackage.GetPackageTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetPackageTypesAsync();

    [MapsToApi(MetrcEndpoint.get_packages_v1_types)]
    Task<ICollection<string>> IPackage.GetPackageTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetPackageTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v1_adjust_reasons)]
    Task<ICollection<PackageAdjustReason>> IPackage.GetPackageAdjustReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PackageAdjustReason>>(new List<PackageAdjustReason>())
            : UserMetrcClient.GetPackageAdjustReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v1_adjust_reasons)]
    Task<ICollection<PackageAdjustReason>> IPackage.GetPackageAdjustReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PackageAdjustReason>>(new List<PackageAdjustReason>())
            : UserMetrcClient.GetPackageAdjustReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    Task IPackage.CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackage2Async(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    Task IPackage.CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackage2Async(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    Task IPackage.CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreateTestingPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    Task IPackage.CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreateTestingPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    Task IPackage.CreatePackagePlantingAsync(string licenseNumber, IEnumerable<CreatePackagePlantingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackagePlantingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    Task IPackage.CreatePackagePlantingAsync(string licenseNumber, IEnumerable<CreatePackagePlantingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackagePlantingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    Task IPackage.ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangePackageItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    Task IPackage.ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangePackageItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    Task IPackage.ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangePackageNoteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    Task IPackage.ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangePackageNoteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    Task IPackage.ChangePackageLocationAsync(string licenseNumber, IEnumerable<ChangePackageLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangePackageLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    Task IPackage.ChangePackageLocationAsync(string licenseNumber, IEnumerable<ChangePackageLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangePackageLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    Task IPackage.AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.AdjustPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    Task IPackage.AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.AdjustPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    Task IPackage.FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.FinishPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    Task IPackage.FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.FinishPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    Task IPackage.UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UnfinishPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    Task IPackage.UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UnfinishPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    Task IPackage.RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.RemediatePackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    Task IPackage.RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.RemediatePackageAsync(licenseNumber, body, cancellationToken);
}