using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int Phone { get; set; }

        public string? User_Name { get; set; }
        public string? Password { get; set; }

        public ICollection<CustomerBook>? CustomerBooks { get; set; }
        public ICollection<Order>? Orders { get; set; }

    }
}
