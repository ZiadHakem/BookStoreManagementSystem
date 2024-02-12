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

        public byte[]? ImageData { get; set; }

        
    }
}
