using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class BookCustomerServices : BookCustomerRepository , IBookCustomerServices
    {
        public BookCustomerServices(StoreContext dbContext) : base(dbContext) { }




    }
}
