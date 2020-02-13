using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Special
    {
        public Special()
        {
            MenuItemSpecial = new HashSet<MenuItemSpecial>();
        }

        public int Id { get; set; }
        public DateTime DateActiveFrom { get; set; }
        public decimal SpecialPrice { get; set; }
        public DateTime DateActiveTo { get; set; }

        public virtual ICollection<MenuItemSpecial> MenuItemSpecial { get; set; }
    }
}
