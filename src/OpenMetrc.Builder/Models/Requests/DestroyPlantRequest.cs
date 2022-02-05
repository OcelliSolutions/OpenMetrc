namespace OpenMetrc.Builder.Models.Requests;

public class DestroyPlantRequest
{
    public DestroyPlantRequest()
    {
        WasteMethodName = string.Empty;
        WasteMaterialMixed = string.Empty;
        WasteUnitOfMeasureName = string.Empty;
        WasteReasonName = string.Empty;
        ReasonNote = string.Empty;
    }

    public int? Id { get; set; }
    public string? Label { get; set; }
    public string WasteMethodName { get; set; }
    public string WasteMaterialMixed { get; set; }
    public double WasteWeight { get; set; }
    public string WasteUnitOfMeasureName { get; set; }
    public string WasteReasonName { get; set; }
    public string ReasonNote { get; set; }
    public DateTime ActualDate { get; set; }
}