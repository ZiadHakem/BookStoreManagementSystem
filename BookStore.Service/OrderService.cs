using BookStore.Core.DTOs;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using BookStore.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class OrderService : OrderRepository, IOrderService
    {
        public OrderService(StoreContext dbContext) : base(dbContext){}

        public List<OrderToReturnDTO>? ReturnOrders()
        {
            List<OrderToReturnDTO>? orders = GetAllOrdersRepo();
            if (orders is not null)
                return orders;
            return null;
        }

        public CheckStatusEnum UpdateOrderStatus(int orderId, OrderStatusEnum newstatus)
        {
            var order = GetOrderToUpdateRepo(orderId);
            if (order is not null)
                return changeOrderStatusRepo(order, newstatus);
            return CheckStatusEnum.NotSaved;

        }
    }
}
