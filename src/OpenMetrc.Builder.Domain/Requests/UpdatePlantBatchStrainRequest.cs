namespace OpenMetrc.Builder.Domain.Requests;

public class UpdatePlantBatchStrainRequest //: CreatePlantBatchStrainRequest
{
    public long? Id { get; set; }
    public string? Name { get; set; }
    public long? StrainId { get; set; }
    public string? StrainName { get; set; }
}