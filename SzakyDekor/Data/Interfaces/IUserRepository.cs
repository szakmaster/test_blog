using System.Threading.Tasks;

namespace SzakyDekor.Data
{
    interface IUserRepository<T> where T: class
    {
        bool Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
        Task<T> SaveAsync(T entity);
    }
}
