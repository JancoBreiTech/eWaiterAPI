using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            SupplierAddress = new HashSet<SupplierAddress>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SupplierAddress> SupplierAddress { get; set; }
    }
}
