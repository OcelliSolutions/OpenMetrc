namespace OpenMetrc.Builder.Domain.Requests;

public class CreateProcessingJobTypesRequest
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? Category { get; set; }
    public string? ProcessingSteps { get; set; }
    public List<string>? Attributes { get; set; }
}