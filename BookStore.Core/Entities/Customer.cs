using BookStore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Navigational Property => Many
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<BookCustomer> CustomerBooks { get; set; } = new List<BookCustomer>();

    }
}
