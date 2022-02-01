namespace OpenMetrc.Builder.Models.Requests;

public class UpdateLabTestDocumentRequest
{
    public UpdateLabTestDocumentRequest()
    {
        DocumentFileName = string.Empty;
        DocumentFileBase64 = string.Empty;
    }
    public int LabTestResultId { get; set; }
    public string DocumentFileName { get; set; }
    public string DocumentFileBase64 { get; set; }
}
