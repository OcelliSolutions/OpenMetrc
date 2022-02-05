namespace OpenMetrc.Builder.Models.Requests;

public class ChangePackageNoteRequest
{
    public ChangePackageNoteRequest()
    {
        PackageLabel = string.Empty;
        Note = string.Empty;
    }

    public string PackageLabel { get; set; }
    public string Note { get; set; }
}