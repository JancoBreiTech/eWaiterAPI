using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class SupplierAgreement
    {
        public SupplierAgreement()
        {
            AgreementSupplier = new HashSet<AgreementSupplier>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? DeliveryLeadTime { get; set; }
        public decimal? StandardPrice { get; set; }
        public string DiscountAgreement { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? MinOrderQty { get; set; }
        public int? MaxOrderQty { get; set; }

        public virtual ICollection<AgreementSupplier> AgreementSupplier { get; set; }
    }
}
