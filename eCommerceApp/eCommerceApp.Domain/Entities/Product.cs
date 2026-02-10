using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceApp.Domain.Entities;

public class Product
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    [Required]
    public string? Base64Image { get; set; } 
    public int Quantity { get; set; }
    public Category? Category { get; set; }
    public Guid CategoryId { get; set; }
}

