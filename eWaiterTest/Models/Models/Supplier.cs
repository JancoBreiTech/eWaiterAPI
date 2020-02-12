using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            AgreementSupplier = new HashSet<AgreementSupplier>();
            IngredientSupplier = new HashSet<IngredientSupplier>();
            SupplierAddress = new HashSet<SupplierAddress>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public string ContactNr { get; set; }
        public string TaxNr { get; set; }

        public virtual ICollection<AgreementSupplier> AgreementSupplier { get; set; }
        public virtual ICollection<IngredientSupplier> IngredientSupplier { get; set; }
        public virtual ICollection<SupplierAddress> SupplierAddress { get; set; }
    }
}
