using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class CreateOrderForIngredient
    {
        public int IngredientId { get; set; }
        public DateTime OrderDate { get; set; }
        public int QtyInOrder { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
