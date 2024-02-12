using BookStore.Core.Entities;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class AdminService : GenericRepository<Admin>, IAdminService
    {
        private readonly StoreContext _dbContext;

        public AdminService(StoreContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Admin?> ChekIfUserExist(string userName, string password)
        {
            var admin = await _dbContext.Admins.FirstOrDefaultAsync(a => a.UserName == userName && a.Password == password);
            if (admin is not null)
                return admin;
            return null;
        }
    }
}

