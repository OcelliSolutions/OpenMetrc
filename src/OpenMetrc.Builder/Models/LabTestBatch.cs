namespace OpenMetrc.Builder.Models;

public class LabTestBatch
{
    public string Name { get; set; } = null!;
    public LabTestType[]? LabTestTypes { get; set; }
}
