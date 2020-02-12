using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Menu
    {
        public Guid RestaurantId { get; set; }
        public Guid MenuItemId { get; set; }
        public DateTime? DateActiveFrom { get; set; }
        public DateTime? DateActiveTo { get; set; }
        public string Description { get; set; }
        public string MenuName { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
