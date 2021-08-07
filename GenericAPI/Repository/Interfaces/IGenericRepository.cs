using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericAPI.Repository.Interfaces
{
   public interface IGenericRepository<T> where T: class
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task CreatedAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeletedAsync(int id);
        Task SaveAllAsync();

    }
}
