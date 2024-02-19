using BookStore.Core.Entities;
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

    public CheckStatusEnum UserLogin(string userName, string password)
    {
        var admin = _dbContext.Admins.FirstOrDefault(a => a.UserName == userName && a.Password == password);
        if (admin is not null)
        {
            if (admin.UserName == userName && admin.Password == password)
                return CheckStatusEnum.Existed;
            else
                return CheckStatusEnum.NotExisted;
        }
        else
            return CheckStatusEnum.NotExisted;
    }

}