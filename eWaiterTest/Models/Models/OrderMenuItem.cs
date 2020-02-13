using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class OrderMenuItem
    {
        public int PlacedOrderId { get; set; }
        public int MenuItemId { get; set; }
        public int ItemQty { get; set; }
        public decimal StartAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal StaffTip { get; set; }
        public decimal Vatamount { get; set; }
        public decimal FinalTotal { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual PlacedOrder PlacedOrder { get; set; }
    }
}
