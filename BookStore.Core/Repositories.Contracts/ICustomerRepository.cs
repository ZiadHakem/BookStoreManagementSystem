using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Repositories.Contracts
{
    public interface ICustomerRepository
    {
        List<Customer>? CheckIfUserExistRepo(string userName, string password);
        Customer? CheckIfCustomerExistRepo(string userName, string password);
    }
}
