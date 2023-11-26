namespace OpenMetrc.Builder.Domain.Requests;

public class PlantBatchSplitRequest
{
    public PlantBatchSplitRequest()
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