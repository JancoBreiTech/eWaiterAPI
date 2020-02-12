using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class SupplierAddress
    {
        public Guid SupplierId { get; set; }
        public Guid AddressTypeId { get; set; }
        public Guid AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
