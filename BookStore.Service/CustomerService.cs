using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using BookStore.Repository.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class CustomerService : CustomerRepository, ICustomerService
    {
        private readonly StoreContext _dbContext;

        public CustomerService(StoreContext dbContext) : base(dbContext)
            => _dbContext = dbContext;

        public bool CheckIfUserExist(string userName, string password)
        {
            var customers = CheckIfUserExistRepo(userName, password);

            if (customers is not null)
                foreach (var customer in customers)
                    if (userName == customer.UserName && password == customer.Password)
                        return true;
            return false;
        }
        public CustomerLoginMsgsDTO CustomerRegister(CustomerLoginParamsDTO customerParams)
        {
            CustomerLoginMsgsDTO Msgs = Validations.ShowCustomerRegisterMsgs(customerParams);

            if (string.IsNullOrEmpty(Msgs.NameMsg) &&
                string.IsNullOrEmpty(Msgs.UserNameMsg) &&
                string.IsNullOrEmpty(Msgs.PasswordMsg) &&
                string.IsNullOrEmpty(Msgs.EmailMsg) &&
                string.IsNullOrEmpty(Msgs.PhoneMsg))
            {
                var customer = MapConfigs.mapper.Map<CustomerLoginParamsDTO, Customer>(customerParams);
                _dbContext.Customers.Add(customer);
                if (_dbContext.SaveChanges() > 0)
                {
                    Msgs.IsSavedMsg = CheckStatusEnum.Saved;
                    return Msgs;
                }
            }
            Msgs.IsSavedMsg = CheckStatusEnum.NotSaved;
            return Msgs;
        }
        public CheckStatusEnum UserLogin(string userName, string password)
        {
            var customer = CheckIfCustomerExistRepo(userName, password);
            if (customer is not null)
            {
                if (customer.UserName == userName && customer.Password == password)
                    return CheckStatusEnum.Existed;
                else
                    return CheckStatusEnum.NotExisted;
            }
            else
                return CheckStatusEnum.NotExisted;
        }
    }
}
