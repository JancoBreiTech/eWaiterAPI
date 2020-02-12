using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class IngredientSupplier
    {
        public Guid IngredientId { get; set; }
        public Guid SupplierId { get; set; }
        public decimal ValueSuppliedToDate { get; set; }
        public int QtySuppliedToDate { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
