using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        // Navigational Property => Many
        public List<BookAuthor> AuthorBooks { get; set; } = new();

    }
}
