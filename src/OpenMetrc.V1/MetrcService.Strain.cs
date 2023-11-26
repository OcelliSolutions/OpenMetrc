namespace OpenMetrc.V1;

public partial class MetrcService : IStrainClient
{
    [MapsToApi(MetrcEndpoint.get_strains_v1_id)]
    Task<Strain> IStrainClient.
        GetStrainByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Strain())
            : StrainClient.GetStrainByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_strains_v1_id)]
    Task IStrainClient.DeleteStrainByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.DeleteStrainByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_strains_v1_active)]
    Task<ICollection<Strain>?> IStrainClient.
        GetStrainActiveAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Strain>?>(new List<Strain>())
            : StrainClient.GetStrainActiveAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_strains_v1_create)]
    Task IStrainClient.PostStrainCreateAsync(string licenseNumber, IEnumerable<PostStrainCreateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.PostStrainCreateAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_strains_v1_update)]
    Task IStrainClient.PostStrainUpdateAsync(string licenseNumber, IEnumerable<PostStrainUpdateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.PostStrainUpdateAsync(licenseNumber, body, cancellationToken);
}