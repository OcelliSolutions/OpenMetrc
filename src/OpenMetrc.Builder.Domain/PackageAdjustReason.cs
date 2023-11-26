namespace OpenMetrc.Builder.Domain;

public class PackageAdjustReason
{
    public PackageAdjustReason()
    {
        Name = string.Empty;
    }

    public string Name { get; set; }
    public bool? RequiresNote { get; set; }
    public bool? RequiresWasteWeight { get; set; }
    public bool? RequiresImmatureWasteWeight { get; set; }
    public bool? RequiresMatureWasteWeight { get; set; }
}