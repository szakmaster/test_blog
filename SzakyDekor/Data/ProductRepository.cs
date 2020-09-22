using System;
using System.Threading.Tasks;
using SzakyDekor.Data.Interfaces;

namespace SzakyDekor.Data
{
    public class ProductRepository<T> : IProductRepository<T> where T : class
    {
        public bool Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
