namespace OpenMetrc.V2;

public partial class MetrcService : IStrainClient
{
    [MapsToApi(MetrcEndpoint.get_strains_v2_id)]
    Task<Strain> IStrainClient.GetStrainByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Strain())
            : StrainClient.GetStrainByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_strains_v2_id)]
    Task<Strain> IStrainClient.
        GetStrainByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Strain())
            : StrainClient.GetStrainByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_strains_v2_id)]
    Task IStrainClient.DeleteStrainAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.DeleteStrainAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_strains_v2_id)]
    Task IStrainClient.DeleteStrainAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.DeleteStrainAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_strains_v2_active)]
    Task<StrainMetrcWrapper> IStrainClient.GetActiveStrainsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StrainMetrcWrapper())
            : StrainClient.GetActiveStrainsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_strains_v2_active)]
    Task<StrainMetrcWrapper> IStrainClient.
        GetActiveStrainsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StrainMetrcWrapper())
            : StrainClient.GetActiveStrainsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_strains_v2_inactive)]
    Task<StrainMetrcWrapper> IStrainClient.GetInactiveStrainsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StrainMetrcWrapper())
            : StrainClient.GetInactiveStrainsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_strains_v2_inactive)]
    Task<StrainMetrcWrapper> IStrainClient.GetInactiveStrainsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StrainMetrcWrapper())
            : StrainClient.GetInactiveStrainsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_strains_v2)]
    Task IStrainClient.CreateStrainAsync(string licenseNumber, IEnumerable<CreateStrainRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.CreateStrainAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_strains_v2)]
    Task IStrainClient.CreateStrainAsync(string licenseNumber, IEnumerable<CreateStrainRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.CreateStrainAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_strains_v2)]
    Task IStrainClient.UpdateStrainAsync(string licenseNumber, IEnumerable<UpdateStrainRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.UpdateStrainAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_strains_v2)]
    Task IStrainClient.UpdateStrainAsync(string licenseNumber, IEnumerable<UpdateStrainRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : StrainClient.UpdateStrainAsync(licenseNumber, body, cancellationToken);
}