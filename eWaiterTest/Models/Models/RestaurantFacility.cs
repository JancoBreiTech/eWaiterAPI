using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantFacility
    {
        public int RestaurantId { get; set; }
        public int FacilityId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
