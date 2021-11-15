using System.ComponentModel.DataAnnotations;
namespace OpenMetrc.Builder.Models;

public class Employee
{
    [MaxLength(100)] public string? FullName { get; set; }
    public License? License { get; set; }
}
