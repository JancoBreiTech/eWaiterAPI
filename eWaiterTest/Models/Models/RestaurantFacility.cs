using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantFacility
    {
        public Guid RestaurantId { get; set; }
        public Guid FacilityId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
