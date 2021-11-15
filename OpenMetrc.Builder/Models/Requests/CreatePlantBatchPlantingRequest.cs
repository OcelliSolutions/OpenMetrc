namespace OpenMetrc.Builder.Models.Requests;

public class CreatePlantBatchPlantingRequest
{
    public CreatePlantBatchPlantingRequest()
    {
        Name = string.Empty;
        Type = string.Empty;
        Strain = string.Empty;
    }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Count { get; set; }
    public string Strain { get; set; }
    public string? Location { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public DateTime ActualDate { get; set; }
}
