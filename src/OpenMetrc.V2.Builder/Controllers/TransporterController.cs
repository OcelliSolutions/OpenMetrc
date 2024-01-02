namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class TransporterController : TransportersControllerBase
{
    #region Driver

    /// <inheritdoc cref="TransportersControllerBase.GetTransporterDrivers" />
    [MapsToApi(MetrcEndpoint.get_transporters_v2_drivers)]
    [ProducesResponseType(typeof(MetrcWrapper<TransporterDriver>), StatusCodes.Status200OK)]
    public override Task GetTransporterDrivers([Required] string licenseNumber,
        int? pageNumber = null,
        int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransportersControllerBase.GetTransporterDriverById" />
    [MapsToApi(MetrcEndpoint.get_transporters_v2_drivers_id)]
    [ProducesResponseType(typeof(TransporterDriver), StatusCodes.Status200OK)]
    public override Task GetTransporterDriverById([Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransportersControllerBase.PostTransporterDrivers" />
    [MapsToApi(MetrcEndpoint.post_transporters_v2_drivers)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostTransporterDrivers([Required] List<PostTransporterDriversRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransportersControllerBase.PutTransporterDrivers" />
    [MapsToApi(MetrcEndpoint.put_transporters_v2_drivers)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutTransporterDrivers([Required] List<PutTransporterDriversRequest> request, [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransportersControllerBase.DeleteTransporterDriverById" />
    [MapsToApi(MetrcEndpoint.delete_transporters_v2_drivers_id)]
    public override Task DeleteTransporterDriverById([Required] long id, [Required] string licenseNumber) => Task.CompletedTask;

    #endregion Driver

    #region Vehicle

    /// <inheritdoc cref="TransportersControllerBase.GetTransporterVehicles" />
    [MapsToApi(MetrcEndpoint.get_transporters_v2_vehicles)]
    [ProducesResponseType(typeof(MetrcWrapper<TransporterVehicle>), StatusCodes.Status200OK)]
    public override Task GetTransporterVehicles([Required] string licenseNumber,
        int? pageNumber = null,
        int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransportersControllerBase.GetTransporterVehicleById" />
    [MapsToApi(MetrcEndpoint.get_transporters_v2_vehicles_id)]
    [ProducesResponseType(typeof(TransporterVehicle), StatusCodes.Status200OK)]
    public override Task GetTransporterVehicleById([Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransportersControllerBase.PostTransporterVehicles" />
    [MapsToApi(MetrcEndpoint.post_transporters_v2_vehicles)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostTransporterVehicles([Required] List<PostTransporterVehiclesRequest> request, [Required] string licenseNumber, string data) => Task.CompletedTask;

    /// <inheritdoc cref="TransportersControllerBase.PutTransporterVehicles" />
    [MapsToApi(MetrcEndpoint.put_transporters_v2_vehicles)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutTransporterVehicles([Required] List<PutTransporterVehiclesRequest> request, [Required] string licenseNumber, string data) => Task.CompletedTask;

    /// <inheritdoc cref="TransportersControllerBase.DeleteTransporterVehicleById" />
    [MapsToApi(MetrcEndpoint.delete_transporters_v2_vehicles_id)]
    public override Task DeleteTransporterVehicleById([Required] long id, [Required] string licenseNumber) => Task.CompletedTask;

    #endregion Vehicle
}