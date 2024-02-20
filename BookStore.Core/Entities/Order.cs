using BookStore.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Order : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public OrderStatusEnum Status { get; set; }
        public int CustomerId { get; set; }

        // Navigational Property => Many
        public ICollection<BookOrder> OrderBooks { get; set; } = new List<BookOrder>();
    }
}
