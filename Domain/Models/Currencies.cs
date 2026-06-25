using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Currencies
{
    [Column("CurrencyId")]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "The field Name is required")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "The field Code is required")]
    public string? Code { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdateAt { get; set; } = DateTime.Now;
    public bool IsActive { get; set; } = true;
}