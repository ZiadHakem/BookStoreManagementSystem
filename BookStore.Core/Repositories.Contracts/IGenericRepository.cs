using BookStore.Core.Entities;
using BookStore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Repositories.Contracts
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T?> GetAsync(int id);
        IEnumerable<T> GetAll();
        CheckStatusEnum Create(T entity);
        T Update(T entity);
        bool Delete(T entity);
    }
}
