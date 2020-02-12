using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class AgreementSupplier
    {
        public Guid SupplierAgreementId { get; set; }
        public Guid SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual SupplierAgreement SupplierAgreement { get; set; }
    }
}
