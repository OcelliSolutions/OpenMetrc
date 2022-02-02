namespace OpenMetrc.Builder.Models.Requests;

public class SplitPlantBatchRequest
{
    public SplitPlantBatchRequest()
    {
        PlantBatch = string.Empty;
        GroupName = string.Empty;
        Strain = string.Empty;
    }

    public string PlantBatch { get; set; }
    public string GroupName { get; set; }
    public int Count { get; set; }
    public string? Location { get; set; }
    public string Strain { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public DateTime ActualDate { get; set; }
}