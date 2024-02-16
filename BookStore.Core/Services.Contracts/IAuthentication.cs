using BookStore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services.Contracts
{
    public interface IAuthentication
    {
        CheckStatusEnum UserLogin(string userName, string password);
    }
}
