using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class BookPublisher
    {
        public int BookID { get; set; }
        public int PublisherID { get; set; }

        public Book? Book { get; set; }
        public Publisher? Publisher { get; set; }
    }
}
