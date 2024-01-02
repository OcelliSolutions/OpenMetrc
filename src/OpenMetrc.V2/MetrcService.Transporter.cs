namespace OpenMetrc.V2;

partial class MetrcService : ITransporterClient
{
    [MapsToApi(MetrcEndpoint.get_transporters_v2_drivers)]
    Task<TransporterDriverMetrcWrapper> ITransporterClient.GetTransporterDriversAsync(string licenseNumber, int? pageNumber = null, int? pageSize = null,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<TransporterDriverMetrcWrapper?>(new TransporterDriverMetrcWrapper())!
            : TransporterClient.GetTransporterDriversAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transporters_v2_drivers)]
    Task ITransporterClient.PostTransporterDriversAsync(string licenseNumber, IEnumerable<PostTransporterDriversRequest> body,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<TransporterDriverMetrcWrapper?>(new TransporterDriverMetrcWrapper())!
            : TransporterClient.PostTransporterDriversAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transporters_v2_drivers)]
    Task ITransporterClient.PutTransporterDriversAsync(string licenseNumber, IEnumerable<PutTransporterDriversRequest> body,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<TransporterDriverMetrcWrapper?>(new TransporterDriverMetrcWrapper())!
            : TransporterClient.PutTransporterDriversAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transporters_v2_drivers_id)]
    Task<TransporterDriver> ITransporterClient.GetTransporterDriverByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<TransporterDriver?>(new TransporterDriver())!
            : TransporterClient.GetTransporterDriverByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transporters_v2_drivers_id)]
    Task ITransporterClient.DeleteTransporterDriverByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransporterClient.DeleteTransporterDriverByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transporters_v2_vehicles)]
    Task<TransporterVehicleMetrcWrapper> ITransporterClient.GetTransporterVehiclesAsync(string licenseNumber, int? pageNumber = null, int? pageSize = null,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<TransporterVehicleMetrcWrapper?>(new TransporterVehicleMetrcWrapper())!
            : TransporterClient.GetTransporterVehiclesAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transporters_v2_vehicles)]
    Task ITransporterClient.PostTransporterVehiclesAsync(string licenseNumber, IEnumerable<PostTransporterVehiclesRequest> body, string? data = null,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<TransporterDriverMetrcWrapper?>(new TransporterDriverMetrcWrapper())!
            : TransporterClient.PostTransporterVehiclesAsync(licenseNumber, body, data, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transporters_v2_vehicles)]
    Task ITransporterClient.PutTransporterVehiclesAsync(string licenseNumber, IEnumerable<PutTransporterVehiclesRequest> body, string? data = null,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<TransporterVehicleMetrcWrapper?>(new TransporterVehicleMetrcWrapper())!
            : TransporterClient.PutTransporterVehiclesAsync(licenseNumber, body, data, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transporters_v2_vehicles_id)]
    Task<TransporterVehicle> ITransporterClient.GetTransporterVehicleByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<TransporterVehicle?>(new TransporterVehicle())!
            : TransporterClient.GetTransporterVehicleByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transporters_v2_vehicles_id)]
    Task ITransporterClient.DeleteTransporterVehicleByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransporterClient.DeleteTransporterVehicleByIdAsync(id, licenseNumber, cancellationToken);
}