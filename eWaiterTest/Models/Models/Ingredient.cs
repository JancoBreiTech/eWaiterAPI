using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            IngredientSupplier = new HashSet<IngredientSupplier>();
            MenuItemIngredient = new HashSet<MenuItemIngredient>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid IngredientTypeId { get; set; }
        public Guid ReorderFreqId { get; set; }
        public int ReorderLevel { get; set; }
        public int ReorderQty { get; set; }
        public decimal StandardCost { get; set; }

        public virtual IngredientType IngredientType { get; set; }
        public virtual ReorderFrequency ReorderFreq { get; set; }
        public virtual CreateOrderForIngredient CreateOrderForIngredient { get; set; }
        public virtual IngredientStockLevel IngredientStockLevel { get; set; }
        public virtual ICollection<IngredientSupplier> IngredientSupplier { get; set; }
        public virtual ICollection<MenuItemIngredient> MenuItemIngredient { get; set; }
    }
}
