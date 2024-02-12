using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class TrackingDetail : BaseEntity
    {
        public string? Status { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
