using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantSeating
    {
        public Guid RestaurantId { get; set; }
        public Guid SeatingId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual Seating Seating { get; set; }
    }
}
