using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MenuItemIngredient
    {
        public Guid IngredientId { get; set; }
        public Guid MenuItemId { get; set; }
        public int ItemQty { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
