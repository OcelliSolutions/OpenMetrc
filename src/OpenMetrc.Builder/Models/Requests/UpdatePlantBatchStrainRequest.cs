namespace OpenMetrc.Builder.Models.Requests;

public class UpdatePlantBatchStrainRequest
{
    public long? Id { get; set; }
    public string? Name { get; set; }
    public long? StrainId { get; set; }
    public string? StrainName { get; set; }
}
