using System.Threading.Tasks;

namespace SzakyDekor.Services.Interfaces
{
    interface IProductService<T> where T: class
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<T> SaveAsync(T entity);
    }
}
