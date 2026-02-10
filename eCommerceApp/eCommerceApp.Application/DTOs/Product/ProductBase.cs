using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace eCommerceApp.Application.DTOs.Product;

public class ProductBase
{
    [Required] 
    public string? Name { get; set; } 
    [Required] 
    public string? Description { get; set; } 
    [Required]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    [Required]
    // [JsonPropertyName("base64Image")] // matches your JSON field
    public string? Base64Image { get; set; } 
    [Required]
    public int Quantity { get; set; }
    [Required]
    public Guid CategoryId { get; set; }
}