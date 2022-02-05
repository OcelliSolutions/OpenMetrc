namespace OpenMetrc.Builder.Models.Requests;

public class ChangeGrowthPhaseForPlantBatchRequest
{
    public ChangeGrowthPhaseForPlantBatchRequest()
    {
        Name = string.Empty;
        StartingTag = string.Empty;
        GrowthPhase = string.Empty;
        NewLocation = string.Empty;
    }

    public string Name { get; set; }
    public int Count { get; set; }
    public string StartingTag { get; set; }
    public string GrowthPhase { get; set; }
    public string NewLocation { get; set; }
    public DateTime GrowthDate { get; set; }
    public string? PatientLicenseNumber { get; set; }
}