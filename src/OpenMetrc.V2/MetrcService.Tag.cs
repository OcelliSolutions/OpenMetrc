namespace OpenMetrc.V2;

public partial class MetrcService : ITagClient
{
    [MapsToApi(MetrcEndpoint.get_tags_v2_plant_available)]
    Task<ICollection<Tag>?> ITagClient.GetTagPlantAvailableAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Tag>?>(new List<Tag>())
            : TagClient.GetTagPlantAvailableAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_tags_v2_package_available)]
    Task<ICollection<Tag>?> ITagClient.GetTagPackageAvailableAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Tag>?>(new List<Tag>())
            : TagClient.GetTagPackageAvailableAsync(licenseNumber, cancellationToken);
}