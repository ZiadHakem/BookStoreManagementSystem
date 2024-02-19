using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Repositories.Contracts;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookCustomerRepository :  IbookCustomersRepository
    {
        private readonly StoreContext _dbContext;
        private DbSet<BookCustomer> dbset;

        public BookCustomerRepository(StoreContext dbContext) 
        {
            _dbContext = dbContext;
            dbset = _dbContext.Set<BookCustomer>();

        }


        public CheckStatusEnum Create(BookCustomer entity)
        {
            dbset.Add(entity);
            if (_dbContext.SaveChanges() > 0)
                return CheckStatusEnum.Saved;
            return CheckStatusEnum.NotSaved;
        }

        public bool Delete(BookCustomer entity)
        {
            dbset.Remove(entity);
            if (_dbContext.SaveChanges() > 0)
                return true;
            return false;
        }






    }
}
