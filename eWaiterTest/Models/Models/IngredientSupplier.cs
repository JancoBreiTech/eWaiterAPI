﻿using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class IngredientSupplier
    {
        public int IngredientId { get; set; }
        public int SupplierId { get; set; }
        public decimal ValueSuppliedToDate { get; set; }
        public int QtySuppliedToDate { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
