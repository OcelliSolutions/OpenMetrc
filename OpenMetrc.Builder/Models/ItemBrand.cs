using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Models;

public class ItemBrand
{
    [MaxLength(100)] public string? Name { get; set; }
    [MaxLength(100)] public string? Status { get; set; }
}
