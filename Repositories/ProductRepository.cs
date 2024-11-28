using Microsoft.EntityFrameworkCore;
using MVC_2024.Data;
using MVC_2024.Models;

namespace MVC_2024.Repositories;
public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetByCategory(Category category)
    {
        return _context.Products.Where(p => 
            p.CategoryId == category.CategoryId).AsNoTracking().ToList();
    }

}
