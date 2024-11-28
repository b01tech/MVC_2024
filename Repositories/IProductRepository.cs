using MVC_2024.Models;

namespace MVC_2024.Repositories;
public interface IProductRepository : IRepository<Product>
{
    IEnumerable<Product> GetByCategory(Category category);
}
