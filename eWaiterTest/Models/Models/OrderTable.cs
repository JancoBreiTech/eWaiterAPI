using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class OrderTable
    {
        public OrderTable()
        {
            PlacedOrder = new HashSet<PlacedOrder>();
            UserTableBooking = new HashSet<UserTableBooking>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string BillSplitYn { get; set; }

        public virtual ICollection<PlacedOrder> PlacedOrder { get; set; }
        public virtual ICollection<UserTableBooking> UserTableBooking { get; set; }
    }
}
