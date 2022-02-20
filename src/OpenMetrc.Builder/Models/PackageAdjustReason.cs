namespace OpenMetrc.Builder.Models;

public class PackageAdjustReason
{
    public PackageAdjustReason()
    {
        Name = string.Empty;
    }

    public string Name { get; set; }
    public bool RequiresNote { get; set; }
}