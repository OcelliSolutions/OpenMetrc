namespace OpenMetrc.Builder.Models.Requests;

public class MoveHarvestRequest
{
    public MoveHarvestRequest()
    {
        HarvestName = string.Empty;
        DryingLocation = string.Empty;
    }

    public long Id { get; set; }
    public string HarvestName { get; set; }
    public string DryingLocation { get; set; }
    public DateTime ActualDate { get; set; }
}