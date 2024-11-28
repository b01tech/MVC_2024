namespace MVC_2024.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        
    }
}
