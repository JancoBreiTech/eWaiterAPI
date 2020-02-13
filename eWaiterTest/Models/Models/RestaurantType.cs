using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantType
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Description { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
