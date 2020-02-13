using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantAddress
    {
        public int RestaurantId { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
