using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MenuItemPrice
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public decimal Price { get; set; }
        public int MenuItemId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
    }
}
