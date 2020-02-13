using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Seating
    {
        public Seating()
        {
            RestaurantSeating = new HashSet<RestaurantSeating>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? SeatingAmount { get; set; }

        public virtual ICollection<RestaurantSeating> RestaurantSeating { get; set; }
    }
}
