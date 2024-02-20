using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        // Navigational Property => Many
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
