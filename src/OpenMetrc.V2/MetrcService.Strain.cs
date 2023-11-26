namespace OpenMetrc.V2;

public partial class MetrcService : IStrainClient
{
    [MapsToApi(MetrcEndpoint.get_strains_v2_id)]
    Task<Strain> IStrainClient.
        GetStrainByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Strain())
            : StrainClient.GetStrainByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_strains_v2_id)]
    Task IStrainClient.DeleteStrainByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.DeleteStrainByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_strains_v2_active)]
    Task<StrainMetrcWrapper> IStrainClient.GetStrainActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StrainMetrcWrapper())
            : StrainClient.GetStrainActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_strains_v2_inactive)]
    Task<StrainMetrcWrapper> IStrainClient.GetStrainInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StrainMetrcWrapper())
            : StrainClient.GetStrainInactiveAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_strains_v2)]
    Task IStrainClient.PostStrainsAsync(string licenseNumber, IEnumerable<PostStrainsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.PostStrainsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_strains_v2)]
    Task IStrainClient.PutStrainsAsync(string licenseNumber, IEnumerable<PutStrainsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.PutStrainsAsync(licenseNumber, body, cancellationToken);
}