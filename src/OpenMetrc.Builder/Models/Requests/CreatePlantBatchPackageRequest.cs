namespace OpenMetrc.Builder.Models.Requests;

public class CreatePlantBatchPackageRequest
{
    public CreatePlantBatchPackageRequest()
    {
        Item = string.Empty;
        Tag = string.Empty;
        Note = string.Empty;
    }

    public int? Id { get; set; }
    public string? PlantBatch { get; set; }
    public int Count { get; set; }
    public string? Location { get; set; }
    public string Item { get; set; }
    public string Tag { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public string Note { get; set; }
    public bool IsTradeSample { get; set; }
    public bool IsDonation { get; set; }
    public DateTime ActualDate { get; set; }
}