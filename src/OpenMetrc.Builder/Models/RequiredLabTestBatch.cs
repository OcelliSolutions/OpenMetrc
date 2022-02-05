namespace OpenMetrc.Builder.Models;

public class RequiredLabTestBatch
{
    public RequiredLabTestBatch()
    {
        LabTestBatchName = string.Empty;
    }

    public int PackageId { get; set; }
    public int LabTestBatchId { get; set; }
    public string LabTestBatchName { get; set; }
}