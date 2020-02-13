using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Address
    {
        public Address()
        {
            RestaurantAddress = new HashSet<RestaurantAddress>();
            SupplierAddress = new HashSet<SupplierAddress>();
        }

        public int Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

        public virtual ICollection<RestaurantAddress> RestaurantAddress { get; set; }
        public virtual ICollection<SupplierAddress> SupplierAddress { get; set; }
    }
}
