namespace OpenMetrc.Builder.Domain.Requests;

public class PackageChangeNoteRequest
{
    public PackageChangeNoteRequest()
    {
        PackageLabel = string.Empty;
        Note = string.Empty;
    }

    public string PackageLabel { get; set; }
    public string Note { get; set; }
}