using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using BookStore.Core.Enums;

namespace BookStore.Core.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public BookStatusEnum Status { get; set; }
        public int CategoryId { get; set; }
        public string? Image { get; set; }

        // Navigational Property => Many
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
        public ICollection<BookPublisher> BookPublishers { get; set; } = new List<BookPublisher>();
        public ICollection<BookOrder> BookOrders { get; set; } = new List<BookOrder>();
        public ICollection<BookCustomer> BookCustomers { get; set; } = new List<BookCustomer>();
    }
}
