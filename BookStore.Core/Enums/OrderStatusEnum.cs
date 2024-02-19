using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Enums
{
    public enum OrderStatusEnum : byte
    {
        Pending, AwaitingShipment, Shipped, Received, Cancelled
    }
}
