using Microsoft.EntityFrameworkCore;
using MVC_2024.Data;

namespace MVC_2024.Repositories;
public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking().ToList();
    }

    public async Task<T> GetById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
      
    }
}



