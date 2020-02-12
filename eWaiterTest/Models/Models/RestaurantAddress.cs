using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantAddress
    {
        public Guid RestaurantId { get; set; }
        public Guid AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
