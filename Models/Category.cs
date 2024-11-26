using System.ComponentModel.DataAnnotations;

namespace MVC_2024.Models;
public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;

    public List<Product> Products { get; set; }
}
