namespace OpenMetrc.Builder.Domain.Requests;

public class UpdatePlantStrainRequest //: CreatePlantStrainRequest
{
    public long Id { get; set; }
    public string? Label { get; set; }
    public long? StrainId { get; set; }
    public string? StrainName { get; set; }
}