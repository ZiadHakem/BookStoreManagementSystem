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

        public GenericRepository(StoreContext dbContext)
            => _dbContext = dbContext;

        public async Task<IEnumerable<T>> GetAllAsync()
            => await _dbContext.Set<T>().ToListAsync();

        public async Task<T?> GetAsync(int id)
            => await _dbContext.Set<T>().FindAsync(id);

        public CheckStatusEnum Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            if (_dbContext.SaveChanges() > 0)
                return CheckStatusEnum.Saved;
            return CheckStatusEnum.NotSaved;
        }

        public bool Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return true;
        }

        public T Update(T entity)
        {
            _dbContext.Update<T>(entity);
            return entity;
        }
    }
}