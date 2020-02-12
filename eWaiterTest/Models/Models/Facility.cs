using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Facility
    {
        public Facility()
        {
            RestaurantFacility = new HashSet<RestaurantFacility>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RestaurantFacility> RestaurantFacility { get; set; }
    }
}
