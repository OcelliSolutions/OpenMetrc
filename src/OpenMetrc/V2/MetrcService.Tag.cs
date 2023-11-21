namespace OpenMetrc.V2;

public partial class MetrcService : ITagClient
{
    [MapsToApi(MetrcEndpoint.get_tags_v2_plant_available)]
    Task<ICollection<Tag>?> ITagClient.GetAvailablePlantTagsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Tag>?>(new List<Tag>())
            : TagClient.GetAvailablePlantTagsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_tags_v2_plant_available)]
    Task<ICollection<Tag>?> ITagClient.GetAvailablePlantTagsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Tag>?>(new List<Tag>())
            : TagClient.GetAvailablePlantTagsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_tags_v2_package_available)]
    Task<ICollection<Tag>?> ITagClient.GetAvailablePackageTagsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Tag>?>(new List<Tag>())
            : TagClient.GetAvailablePackageTagsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_tags_v2_package_available)]
    Task<ICollection<Tag>?> ITagClient.GetAvailablePackageTagsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Tag>?>(new List<Tag>())
            : TagClient.GetAvailablePackageTagsAsync(licenseNumber, cancellationToken);
}