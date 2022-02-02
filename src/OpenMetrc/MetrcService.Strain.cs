namespace OpenMetrc;

public partial class MetrcService : IStrain
{
    [MapsToApi(MetrcEndpoint.get_strains_v1_id)]
    Task<Strain> IStrain.GetStrainByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Strain())
            : MetrcClient.GetStrainByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_strains_v1_id)]
    Task<Strain> IStrain.GetStrainByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Strain())
            : MetrcClient.GetStrainByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_strains_v1_id)]
    Task IStrain.DeleteStrainAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteStrainAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_strains_v1_id)]
    Task IStrain.DeleteStrainAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteStrainAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_strains_v1_active)]
    Task<ICollection<Strain>> IStrain.GetActiveStrainsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Strain>>(new List<Strain>())
            : MetrcClient.GetActiveStrainsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_strains_v1_active)]
    Task<ICollection<Strain>> IStrain.
        GetActiveStrainsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Strain>>(new List<Strain>())
            : MetrcClient.GetActiveStrainsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_strains_v1_create)]
    Task IStrain.CreateStrainAsync(string licenseNumber, IEnumerable<CreateStrainRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateStrainAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_strains_v1_create)]
    Task IStrain.CreateStrainAsync(string licenseNumber, IEnumerable<CreateStrainRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateStrainAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_strains_v1_update)]
    Task IStrain.UpdateStrainAsync(string licenseNumber, IEnumerable<UpdateStrainRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateStrainAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_strains_v1_update)]
    Task IStrain.UpdateStrainAsync(string licenseNumber, IEnumerable<UpdateStrainRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateStrainAsync(licenseNumber, body, cancellationToken);
}