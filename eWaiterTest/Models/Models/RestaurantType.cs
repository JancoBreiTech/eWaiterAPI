using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantType
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public string Description { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
