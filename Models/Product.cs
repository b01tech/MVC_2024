using System.ComponentModel.DataAnnotations;

namespace MVC_2024.Models;
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [StringLength(200)]
    public string Description { get; set; } = string.Empty;
    [Required]   
    public decimal  Price { get; set; }
    public string  ImageUrl { get; set; } = string.Empty ;
    public bool IsActive { get; set; }

    public int CategoryId {     get; set; }
    public Category Category { get; set; }

}
