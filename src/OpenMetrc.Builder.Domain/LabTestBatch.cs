namespace OpenMetrc.Builder.Domain;

public class LabTestBatch
{
    public string Name { get; set; } = null!;
    public LabTestType[]? LabTestTypes { get; set; }
}