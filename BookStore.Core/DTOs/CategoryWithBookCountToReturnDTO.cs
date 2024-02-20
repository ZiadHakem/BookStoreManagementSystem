using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.DTOs
{
    public class CategoryWithBookCountToReturnDTO
    {
        public Category Category { get; set; }
        public int BookCount { get; set; }
    }
}
