namespace OpenMetrc.Builder.Models.Requests;

public class FinishPackageRequest
{
    public FinishPackageRequest()
    {
        Label = string.Empty;
    }
    public string Label { get; set; }
    public DateTime ActualDate { get; set; }
}
