﻿using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using BookStore.Service;

public class AdminService : GenericRepository<Admin>, IAdminService
{
    private readonly StoreContext _dbContext;

    public AdminService(StoreContext dbContext) : base(dbContext)
        => _dbContext = dbContext;

    public int UserLogin(string userName, string password)
    {
        var admin = _dbContext.Admins.FirstOrDefault(a => a.UserName == userName && a.Password == password);
        if (admin is not null)
        {
            if (admin.UserName == userName && admin.Password == password)
                return admin.Id;
            else
                return -1;
        }
        else
            return -1;
    }

}