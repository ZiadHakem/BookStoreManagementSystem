﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Order : BaseEntity
    {
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int Status { get; set; }

        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
