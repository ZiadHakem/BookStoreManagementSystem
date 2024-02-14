using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace BookStore.Core.Entities
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Statue { get; set; }

        public string? Image { get; set; }

        public ICollection<CustomerBook>? CustomerBooks { get; set; }
        public ICollection<BookPublisher>? BookPublishers { get; set; }
        public ICollection<BookAuthor>? BookAuthors { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
