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

    Task IPackageClient.DeletePackageAsync(long id, string licenseNumber) => throw new NotImplementedException();

    Task IPackageClient.DeletePackageAsync(long id, string licenseNumber, CancellationToken cancellationToken) => throw new NotImplementedException();

    Task<PackageSourceHarvest> IPackageClient.GetPackageSourceHarvestsAsync(long id, string licenseNumber) => throw new NotImplementedException();

    Task<PackageSourceHarvest> IPackageClient.GetPackageSourceHarvestsAsync(long id, string licenseNumber, CancellationToken cancellationToken) => throw new NotImplementedException();

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

    [MapsToApi(MetrcEndpoint.get_packages_v2_active)]
    Task<PackageMetrcWrapper> IPackageClient.GetActivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetActivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v2_active)]
    Task<PackageMetrcWrapper> IPackageClient.GetActivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetActivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_onhold)]
    Task<PackageMetrcWrapper> IPackageClient.GetOnHoldPackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetOnHoldPackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v2_onhold)]
    Task<PackageMetrcWrapper> IPackageClient.GetOnHoldPackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetOnHoldPackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_packages_v2_inactive)]
    Task<PackageMetrcWrapper> IPackageClient.GetInactivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetInactivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_packages_v2_inactive)]
    Task<PackageMetrcWrapper> IPackageClient.GetInactivePackagesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageMetrcWrapper())
            : PackageClient.GetInactivePackagesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    Task<PackageMetrcWrapper> IPackageClient.GetIntransitPackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        throw new NotImplementedException();

    Task<PackageMetrcWrapper> IPackageClient.GetIntransitPackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        throw new NotImplementedException();

    Task<PackageLabTestMetrcWrapper> IPackageClient.GetPackageLabTestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) => throw new NotImplementedException();

    Task<PackageLabTestMetrcWrapper> IPackageClient.GetPackageLabTestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        throw new NotImplementedException();

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
    Task<PackageAdjustReasonMetrcWrapper> IPackageClient.GetPackageAdjustReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageAdjustReasonMetrcWrapper())
            : PackageClient.GetPackageAdjustReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_packages_v2_adjust_reasons)]
    Task<PackageAdjustReasonMetrcWrapper> IPackageClient.GetPackageAdjustReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PackageAdjustReasonMetrcWrapper())
            : PackageClient.GetPackageAdjustReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v2)]
    Task IPackageClient.CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreatePackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v2)]
    Task IPackageClient.CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreatePackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v2_testing)]
    Task IPackageClient.CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreateTestingPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v2_testing)]
    Task IPackageClient.CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreateTestingPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_packages_v2_plantings)]
    Task IPackageClient.CreatePackagePlantingAsync(string licenseNumber,
        IEnumerable<CreatePackagePlantingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreatePackagePlantingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v2_plantings)]
    Task IPackageClient.CreatePackagePlantingAsync(string licenseNumber,
        IEnumerable<CreatePackagePlantingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.CreatePackagePlantingAsync(licenseNumber, body, cancellationToken);

    Task IPackageClient.FlagPackageForDonationAsync(string licenseNumber, IEnumerable<PackageDonationRequest> body) => throw new NotImplementedException();

    Task IPackageClient.FlagPackageForDonationAsync(string licenseNumber, IEnumerable<PackageDonationRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    Task IPackageClient.UnflagPackageForDonationAsync(string licenseNumber, IEnumerable<PackageDonationRequest> body) => throw new NotImplementedException();

    Task IPackageClient.UnflagPackageForDonationAsync(string licenseNumber, IEnumerable<PackageDonationRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.put_packages_v2_item)]
    Task IPackageClient.ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_item)]
    Task IPackageClient.ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_note)]
    Task IPackageClient.ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageNoteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_note)]
    Task IPackageClient.ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageNoteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_location)]
    Task IPackageClient.ChangePackageLocationAsync(string licenseNumber,
        IEnumerable<ChangePackageLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_location)]
    Task IPackageClient.ChangePackageLocationAsync(string licenseNumber,
        IEnumerable<ChangePackageLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.ChangePackageLocationAsync(licenseNumber, body, cancellationToken);

    Task IPackageClient.PackageLabTestsRequiredAsync(string licenseNumber, IEnumerable<PackageLabTestsRequiredRequest> body) => throw new NotImplementedException();

    Task IPackageClient.PackageLabTestsRequiredAsync(string licenseNumber, IEnumerable<PackageLabTestsRequiredRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    Task IPackageClient.FlagPackageTradeSampleAsync(string licenseNumber, IEnumerable<PackageTradeSampleRequest> body) => throw new NotImplementedException();

    Task IPackageClient.FlagPackageTradeSampleAsync(string licenseNumber, IEnumerable<PackageTradeSampleRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    Task IPackageClient.UnflagPackageTradeSampleAsync(string licenseNumber, IEnumerable<PackageTradeSampleRequest> body) => throw new NotImplementedException();

    Task IPackageClient.UnflagPackageTradeSampleAsync(string licenseNumber, IEnumerable<PackageTradeSampleRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_packages_v2_adjust)]
    Task IPackageClient.AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.AdjustPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_packages_v2_adjust)]
    Task IPackageClient.AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.AdjustPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_finish)]
    Task IPackageClient.FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.FinishPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_finish)]
    Task IPackageClient.FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.FinishPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_unfinish)]
    Task IPackageClient.UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.UnfinishPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_unfinish)]
    Task IPackageClient.UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.UnfinishPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_packages_v2_remediate)]
    Task IPackageClient.RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.RemediatePackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_packages_v2_remediate)]
    Task IPackageClient.RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PackageClient.RemediatePackageAsync(licenseNumber, body, cancellationToken);
}