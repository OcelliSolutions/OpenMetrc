namespace OpenMetrc.Builder.Models;

public class PackageLabTestBatch
{
    public int PackageId { get; set; }
    public int LabTestBatchId { get; set; }
    [MaxLength(100)] public string? LabTestBatchName { get; set; }
}