using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class FoodType
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
