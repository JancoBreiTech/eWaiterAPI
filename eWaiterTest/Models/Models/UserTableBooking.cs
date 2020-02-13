using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class UserTableBooking
    {
        public int CustomerId { get; set; }
        public int OrderTableId { get; set; }
        public DateTime DateBookingMade { get; set; }
        public DateTime DateTableBookedFor { get; set; }
        public int NumberInParty { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual OrderTable OrderTable { get; set; }
    }
}
