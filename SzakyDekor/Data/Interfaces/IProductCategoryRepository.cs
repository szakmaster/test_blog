﻿using System.Threading.Tasks;

namespace SzakyDekor.Data.Interfaces
{
    interface IProductCategoryRepository<T> where T: class
    {
        bool Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
        Task<T> SaveAsync(T entity);
    }
}
