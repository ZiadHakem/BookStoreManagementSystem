using BookStore.Core.Entities;
using BookStore.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.DTOs
{
    public class OrderToReturnDTO
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public OrderStatusEnum Status { get; set; }
        public string Customer { get; set; }
        public List<string> Books { get; set; }
    }
}
