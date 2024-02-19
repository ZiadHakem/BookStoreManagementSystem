using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Repositories.Contracts;
using BookStore.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _dbContext;
        private DbSet<T> dbset ;

        public GenericRepository(StoreContext dbContext)
        { _dbContext = dbContext;

            dbset = _dbContext.Set<T>();

        }

        public IEnumerable<T> GetAll()
            => dbset.ToList();

        public async Task<T?> GetAsync(int id)
            => await dbset.FindAsync(id);

        public CheckStatusEnum Create(T entity)
        {
            dbset.Add(entity);
            if (_dbContext.SaveChanges() > 0)
                return CheckStatusEnum.Saved;
            return CheckStatusEnum.NotSaved;
        }

        public bool Delete(T entity)
        {
            dbset.Remove(entity);
            if (_dbContext.SaveChanges() > 0)
                return true;
            return false;
        }

        public T Update(T entity)
        {
            _dbContext.Update<T>(entity);
            return entity;
        }
    }
}