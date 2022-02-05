namespace OpenMetrc.Builder.Models.Requests;

public class ChangePlantGrowthPhaseRequest
{
    public ChangePlantGrowthPhaseRequest()
    {
        NewTag = string.Empty;
        GrowthPhase = string.Empty;
        NewLocation = string.Empty;
    }

    public int? Id { get; set; }
    public string? Label { get; set; }
    public string NewTag { get; set; }
    public string GrowthPhase { get; set; }
    public string NewLocation { get; set; }
    public DateTime GrowthDate { get; set; }
}