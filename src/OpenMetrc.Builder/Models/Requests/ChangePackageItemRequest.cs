namespace OpenMetrc.Builder.Models.Requests;

public class ChangePackageItemRequest
{
    public ChangePackageItemRequest()
    {
        Label = string.Empty;
        Item = string.Empty;
    }

    [Required] public string Label { get; set; }

    [Required] public string Item { get; set; }
}