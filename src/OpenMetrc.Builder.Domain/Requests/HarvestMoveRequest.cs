namespace OpenMetrc.Builder.Domain.Requests;

public class HarvestMoveRequest
{
    public HarvestMoveRequest()
    {
        HarvestName = string.Empty;
        DryingLocation = string.Empty;
    }

    public long Id { get; set; }
    public string HarvestName { get; set; }
    public string DryingLocation { get; set; }
    public DateTime ActualDate { get; set; }
}