using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Repositories.Contracts;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Repository.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStore.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private StoreContext _dbContext;
        public OrderRepository(StoreContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        

        public List<OrderToReturnDTO>? GetAllOrdersRepo()
        {
            var query = from order in _dbContext.Orders
                        join customer in _dbContext.Customers on order.CustomerId equals customer.Id
                        select new OrderToReturnDTO
                        {
                            OrderId = order.Id,
                            Amount = order.Amount,
                            Date = order.Date,
                            Status = order.Status,
                            Customer = customer.Name,
                            Books = (from bookOrder in order.OrderBooks
                                     join book in _dbContext.Books on bookOrder.BookId equals book.Id
                                     select book.Title).ToList()
                        };

            List<OrderToReturnDTO> ordersToReturnDTO = query.ToList();
            return ordersToReturnDTO;
        }

        public Order? GetOrderToUpdateRepo(int orderId)
        {
            var order = _dbContext.Orders.Find(orderId);
            return order;
        }

        public CheckStatusEnum changeOrderStatusRepo(Order order, OrderStatusEnum newstatus)
        {
            order.Status = newstatus;
            if (_dbContext.SaveChanges() > 0)
                return CheckStatusEnum.Saved;
            else
                return CheckStatusEnum.NotSaved;
        }
    }
}
