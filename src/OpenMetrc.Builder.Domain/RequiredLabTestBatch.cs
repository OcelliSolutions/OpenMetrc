namespace OpenMetrc.Builder.Domain;

public class RequiredLabTestBatch
{
    public RequiredLabTestBatch()
    {
        LabTestBatchName = string.Empty;
    }

    public long PackageId { get; set; }
    public long LabTestBatchId { get; set; }
    public string LabTestBatchName { get; set; }
}