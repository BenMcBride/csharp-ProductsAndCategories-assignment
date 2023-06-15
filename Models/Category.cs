#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;
public class Category
{
  [Key]
  public int CategoryId { get; set; }
  [Required]
  [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
  [MaxLength(30, ErrorMessage = "must be at most 30 characters.")]
  public string Name { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;
  public List<Association> AllAssociations { get; set; } = new List<Association>();
}
