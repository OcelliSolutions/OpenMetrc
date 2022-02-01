using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Models;

public class HarvestWasteType
{
    [MaxLength(100)] public string? Name { get; set; }
}
