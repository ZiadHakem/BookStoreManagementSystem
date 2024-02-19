using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.DTOs
{
    public class CategoryToReturnDTO
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int CountOfBooks { get; set; }
    }
}
