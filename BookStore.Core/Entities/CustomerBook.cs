using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class CustomerBook
    {
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int NumOfBooks { get; set; }
    }
}
