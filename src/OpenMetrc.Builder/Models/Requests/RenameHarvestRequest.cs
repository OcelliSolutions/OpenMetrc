namespace OpenMetrc.Builder.Models.Requests;

public class RenameHarvestRequest
{
    public RenameHarvestRequest()
    {
        OldName = string.Empty;
        NewName = string.Empty;
    }

    public long Id { get; set; }
    public string OldName { get; set; }
    public string NewName { get; set; }
}