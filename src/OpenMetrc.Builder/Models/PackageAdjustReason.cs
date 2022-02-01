using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Models;

public class PackageAdjustReason
{
    public PackageAdjustReason()
    {
        Name = string.Empty;
    }
    [MaxLength(100)] public string Name { get; set; }
    public bool RequiresNote { get; set; }
}
