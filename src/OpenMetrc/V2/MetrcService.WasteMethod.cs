namespace OpenMetrc.V2;

public partial class MetrcService : IWasteMethodClient
{
    [MapsToApi(MetrcEndpoint.get_wastemethods_v2)]
    Task<ICollection<WasteMethod>?> IWasteMethodClient.GetWasteMethodsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<WasteMethod>?>(new List<WasteMethod>())
            : WasteMethodClient.GetWasteMethodsAsync();

    [MapsToApi(MetrcEndpoint.get_wastemethods_v2)]
    Task<ICollection<WasteMethod>?> IWasteMethodClient.GetWasteMethodsAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<WasteMethod>?>(new List<WasteMethod>())
            : WasteMethodClient.GetWasteMethodsAsync(cancellationToken);
}