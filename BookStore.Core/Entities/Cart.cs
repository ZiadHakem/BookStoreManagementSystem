using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Cart:BaseEntity
    {
        public int Price { get; set; }

        public int NumberOfBooks { get; set; }
    }
}
