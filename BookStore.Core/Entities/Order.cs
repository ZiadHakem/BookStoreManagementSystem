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

        public TrackingDetail TrackingDetail { get; set; }
    }
}
