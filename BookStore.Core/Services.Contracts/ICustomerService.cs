using BookStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services.Contracts
{
    public interface ICustomerService : IAuthentication
    {
        public CustomerLoginMsgsDTO CustomerRegister(CustomerLoginParamsDTO customerParams);
    }
}
