using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Repositories.Contracts
{
    public interface IOrderRepository
    {
        List<OrderToReturnDTO>? GetAllOrdersRepo();
        Order? GetOrderToUpdateRepo(int orderId);
        CheckStatusEnum changeOrderStatusRepo(Order order, OrderStatusEnum newstatus);
    }
}
