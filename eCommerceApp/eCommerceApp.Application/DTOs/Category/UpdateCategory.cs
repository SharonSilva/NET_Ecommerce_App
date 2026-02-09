using System.ComponentModel.DataAnnotations;
using eCommerceApp.Application.DTOs.Product;

namespace eCommerceApp.Application.DTOs.Category;

public class UpdateCategory : CategoryBase
{
    [Required]
    public Guid Id { get; set; }
    
}

