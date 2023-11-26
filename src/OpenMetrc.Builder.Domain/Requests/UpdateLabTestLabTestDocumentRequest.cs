namespace OpenMetrc.Builder.Domain.Requests;

public class UpdateLabTestLabTestDocumentRequest
{
    public UpdateLabTestLabTestDocumentRequest()
    {
        DocumentFileName = string.Empty;
        DocumentFileBase64 = string.Empty;
    }

    public long LabTestResultId { get; set; }
    public string DocumentFileName { get; set; }
    public string DocumentFileBase64 { get; set; }
}