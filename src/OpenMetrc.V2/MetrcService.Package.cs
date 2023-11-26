namespace OpenMetrc.V2;

public partial class MetrcService : IPackageClient
{
    [MapsToApi(MetrcEndpoint.get_packages_v2_id)]
    Task<Package> IPackageClient.GetPackageByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : PackageClient.GetPackageByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v2_id)]
    Task<Package> IPackageClient.GetPackageByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : PackageClient.GetPackageByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_packages_v2_id)]
    Task IPackageClient.DeletePackageByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.DeletePackageByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_packages_v2_id)]
    Task IPackageClient.DeletePackageByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.DeletePackageByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_id_source_harvests)]
    Task<PackageSourceHarvestMetrcWrapper> IPackageClient.GetPackageByIdSourceHarvestsAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageSourceHarvestMetrcWrapper())
            : PackageClient.GetPackageByIdSourceHarvestsAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v2_id_source_harvests)]
    Task<PackageSourceHarvestMetrcWrapper> IPackageClient.GetPackageByIdSourceHarvestsAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageSourceHarvestMetrcWrapper())
            : PackageClient.GetPackageByIdSourceHarvestsAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_label)]
    Task<Package> IPackageClient.GetPackageByLabelAsync(string label, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : PackageClient.GetPackageByLabelAsync(label, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v2_label)]
    Task<Package> IPackageClient.GetPackageByLabelAsync(string label, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Package())
            : PackageClient.GetPackageByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_labsamples)]
    Task<PackageLabSampleMetrcWrapper> IPackageClient.GetPackageLabSamplesAsync(string licenseNumber, int? pageNumber, int? pageSize, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageLabSampleMetrcWrapper())
            : PackageClient.GetPackageLabSamplesAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v2_labsamples)]
    Task<PackageLabSampleMetrcWrapper> IPackageClient.GetPackageLabSamplesAsync(string licenseNumber, int? pageNumber, int? pageSize, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageLabSampleMetrcWrapper())
            : PackageClient.GetPackageLabSamplesAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_active)]
    Task<PackageMetrcWrapper> IPackageClient.GetPackageActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetPackageActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v2_active)]
    Task<PackageMetrcWrapper> IPackageClient.GetPackageActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetPackageActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_onhold)]
    Task<PackageMetrcWrapper> IPackageClient.GetPackageOnHoldAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetPackageOnHoldAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v2_onhold)]
    Task<PackageMetrcWrapper> IPackageClient.GetPackageOnHoldAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetPackageOnHoldAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_inactive)]
    Task<PackageMetrcWrapper> IPackageClient.GetPackageInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetPackageInactiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v2_inactive)]
    Task<PackageMetrcWrapper> IPackageClient.GetPackageInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetPackageInactiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_intransit)]
    Task<PackageMetrcWrapper> IPackageClient.GetPackageIntransitAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetPackageIntransitAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v2_intransit)]
    Task<PackageMetrcWrapper> IPackageClient.GetPackageIntransitAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetPackageIntransitAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_labtests_required)]
    Task IPackageClient.PutPackageLabTestRequiredAsync(string licenseNumber, IEnumerable<PutPackageLabTestRequiredRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.PutPackageLabTestRequiredAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_labtests_required)]
    Task IPackageClient.PutPackageLabTestRequiredAsync(string licenseNumber, IEnumerable<PutPackageLabTestRequiredRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.PutPackageLabTestRequiredAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_types)]
    Task<StringMetrcWrapper> IPackageClient.GetPackageTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PackageClient.GetPackageTypesAsync();

    [MapsToApi(MetrcEndpoint.get_packages_v2_types)]
    Task<StringMetrcWrapper> IPackageClient.GetPackageTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PackageClient.GetPackageTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_adjust_reasons)]
    Task<PackageAdjustReasonMetrcWrapper> IPackageClient.GetPackageAdjustReasonsAsync(string licenseNumber,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageAdjustReasonMetrcWrapper())
            : PackageClient.GetPackageAdjustReasonsAsync(licenseNumber, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_packages_v2_adjust_reasons)]
    Task<PackageAdjustReasonMetrcWrapper> IPackageClient.GetPackageAdjustReasonsAsync(string licenseNumber,
        int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageAdjustReasonMetrcWrapper())
            : PackageClient.GetPackageAdjustReasonsAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v2)]
    Task IPackageClient.PostPackagesAsync(string licenseNumber, IEnumerable<PostPackagesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackagesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v2)]
    Task IPackageClient.PostPackagesAsync(string licenseNumber, IEnumerable<PostPackagesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackagesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v2_testing)]
    Task IPackageClient.PostPackageTestingAsync(string licenseNumber, IEnumerable<PostPackageTestingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageTestingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v2_testing)]
    Task IPackageClient.PostPackageTestingAsync(string licenseNumber, IEnumerable<PostPackageTestingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageTestingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v2_plantings)]
    Task IPackageClient.PostPackagePlantingsAsync(string licenseNumber,
        IEnumerable<PostPackagePlantingsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackagePlantingsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v2_plantings)]
    Task IPackageClient.PostPackagePlantingsAsync(string licenseNumber,
        IEnumerable<PostPackagePlantingsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackagePlantingsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_donation_flag)]
    Task IPackageClient.PutPackageDonationFlagAsync(string licenseNumber, IEnumerable<PutPackageDonationFlagRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageDonationFlagAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_donation_flag)]
    Task IPackageClient.PutPackageDonationFlagAsync (string licenseNumber, IEnumerable<PutPackageDonationFlagRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageDonationFlagAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_donation_unflag)]
    Task IPackageClient.PutPackageDonationUnflagAsync(string licenseNumber, IEnumerable<PutPackageDonationUnflagRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageDonationUnflagAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_donation_unflag)]
    Task IPackageClient.PutPackageDonationUnflagAsync(string licenseNumber, IEnumerable<PutPackageDonationUnflagRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageDonationUnflagAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_item)]
    Task IPackageClient.PutPackageItemAsync(string licenseNumber, IEnumerable<PutPackageItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_item)]
    Task IPackageClient.PutPackageItemAsync(string licenseNumber, IEnumerable<PutPackageItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_note)]
    Task IPackageClient.PutPackageNoteAsync(string licenseNumber, IEnumerable<PutPackageNoteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageNoteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_note)]
    Task IPackageClient.PutPackageNoteAsync(string licenseNumber, IEnumerable<PutPackageNoteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageNoteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_location)]
    Task IPackageClient.PutPackageLocationAsync(string licenseNumber,
        IEnumerable<PutPackageLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_location)]
    Task IPackageClient.PutPackageLocationAsync(string licenseNumber,
        IEnumerable<PutPackageLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_tradesample_flag)]
    Task IPackageClient.PutPackageTradeSampleFlagAsync(string licenseNumber, IEnumerable<PutPackageTradeSampleFlagRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageTradeSampleFlagAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_tradesample_flag)]
    Task IPackageClient.PutPackageTradeSampleFlagAsync(string licenseNumber, IEnumerable<PutPackageTradeSampleFlagRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageTradeSampleFlagAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_tradesample_unflag)]
    Task IPackageClient.PutPackageTradeSampleUnflagAsync(string licenseNumber, IEnumerable<PutPackageTradeSampleUnflagRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageTradeSampleUnflagAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_tradesample_unflag)]
    Task IPackageClient.PutPackageTradeSampleUnflagAsync(string licenseNumber, IEnumerable<PutPackageTradeSampleUnflagRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageTradeSampleUnflagAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v2_adjust)]
    Task IPackageClient.PostPackageAdjustAsync(string licenseNumber, IEnumerable<PostPackageAdjustRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageAdjustAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v2_adjust)]
    Task IPackageClient.PostPackageAdjustAsync(string licenseNumber, IEnumerable<PostPackageAdjustRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PostPackageAdjustAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_finish)]
    Task IPackageClient.PutPackageFinishAsync(string licenseNumber, IEnumerable<PutPackageFinishRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageFinishAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_finish)]
    Task IPackageClient.PutPackageFinishAsync(string licenseNumber, IEnumerable<PutPackageFinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageFinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_unfinish)]
    Task IPackageClient.PutPackageUnfinishAsync(string licenseNumber, IEnumerable<PutPackageUnfinishRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageUnfinishAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_unfinish)]
    Task IPackageClient.PutPackageUnfinishAsync(string licenseNumber, IEnumerable<PutPackageUnfinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageUnfinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_remediate)]
    Task IPackageClient.PutPackageRemediateAsync(string licenseNumber, IEnumerable<PutPackageRemediateRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageRemediateAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_remediate)]
    Task IPackageClient.PutPackageRemediateAsync(string licenseNumber, IEnumerable<PutPackageRemediateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.PutPackageRemediateAsync(licenseNumber, body, cancellationToken);
}