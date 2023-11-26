namespace OpenMetrc.Builder.Domain.Requests;

public class PackageChangeItemRequest
{
    public PackageChangeItemRequest()
    {
        Label = string.Empty;
        Item = string.Empty;
    }

    [Required] public string Label { get; set; }

    [Required] public string Item { get; set; }
}