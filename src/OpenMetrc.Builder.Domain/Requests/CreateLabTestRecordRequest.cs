namespace OpenMetrc.Builder.Domain.Requests;

public class CreateLabTestRecordRequest
{
    public CreateLabTestRecordRequest()
    {
        Label = string.Empty;
        Results = new List<LabTestResult>();
    }

    [Required] public string Label { get; set; }

    [Required] public DateTime ResultDate { get; set; }

    public string? DocumentFileName { get; set; }
    public string? DocumentFileBase64 { get; set; }

    [Required] public List<LabTestResult> Results { get; set; }

    public class LabTestResult
    {
        public LabTestResult()
        {
            LabTestTypeName = string.Empty;
            Notes = string.Empty;
        }

        [Required] public string LabTestTypeName { get; set; }

        [Required] public double Quantity { get; set; }

        [Required] public bool Passed { get; set; }

        [Required] public string Notes { get; set; }
    }
}