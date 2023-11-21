namespace OpenMetrc.Builder.Models.Requests;

public class UpdatePlantStrainRequest
{
    public long Id { get; set; }
    public string? Label { get; set; }
    public long? StrainId { get; set; }
    public string? StrainName { get; set; }
}
