using System;
using System.Threading.Tasks;

namespace SzakyDekor.Data
{
    public class UserRepository<T> : IUserRepository<T> where T : class
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
