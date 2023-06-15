#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;
public class Product
{
  [Key]
  public int ProductId { get; set; }
  [Required]
  [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
  [MaxLength(30, ErrorMessage = "must be at most 30 characters.")]
  public string Name { get; set; }
  [Required]
  [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
  public string Description { get; set; }
  [Required(ErrorMessage = "The Price field is required.")]
  [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0.")]
  public decimal Price { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;
  public List<Association> AllAssociations { get; set; } = new List<Association>();
}
