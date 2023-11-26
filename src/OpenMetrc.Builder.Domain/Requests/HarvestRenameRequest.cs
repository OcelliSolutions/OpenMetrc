namespace OpenMetrc.Builder.Domain.Requests;

public class HarvestRenameRequest
{
    public HarvestRenameRequest()
    {
        OldName = string.Empty;
        NewName = string.Empty;
    }

    public long Id { get; set; }
    public string OldName { get; set; }
    public string NewName { get; set; }
}