namespace OpenMetrc.Builder.Models;

public class ProcessingJobType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? CategoryName { get; set; }
    public string? ProcessingSteps { get; set; }
    public List<string>? Attributes { get; set; }
}
