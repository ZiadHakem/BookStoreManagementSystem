using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class BookAuthor
    {
        public int BookID { get; set; }
        public Book? Book { get; set; }

        public int AuthorID { get; set; }
        public Author? Author { get; set; }
    }
}
