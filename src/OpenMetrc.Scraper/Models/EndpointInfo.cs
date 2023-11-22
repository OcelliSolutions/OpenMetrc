namespace OpenMetrc.Scraper.Models;
internal class EndpointInfo
{
    public string OperationId { get; set; } = null!;
    public string HttpMethod { get; set; } = null!;
    public string Url { get; set; } = null!;
    public List<ParameterInfo> Parameters { get; set; } = new();
    public string? ExampleRequest { get; set; }
    public string? ExampleResponse { get; set; }
}