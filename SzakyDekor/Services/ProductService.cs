using System;
using System.Threading.Tasks;
using SzakyDekor.Services.Interfaces;

namespace SzakyDekor.Services
{
    public class ProductService<T> : IProductService<T> where T : class
    {
        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
