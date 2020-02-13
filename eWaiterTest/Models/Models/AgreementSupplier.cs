using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class AgreementSupplier
    {
        public int SupplierAgreementId { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual SupplierAgreement SupplierAgreement { get; set; }
    }
}
