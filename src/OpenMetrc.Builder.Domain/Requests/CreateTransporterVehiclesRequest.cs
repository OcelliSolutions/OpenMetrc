namespace OpenMetrc.Builder.Domain.Requests;

public class CreateTransporterVehiclesRequest
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public string? LicensePlateNumber { get; set; }
}