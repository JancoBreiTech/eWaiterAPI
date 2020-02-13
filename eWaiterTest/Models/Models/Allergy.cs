using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Allergy
    {
        public Allergy()
        {
            MenuItemAllergy = new HashSet<MenuItemAllergy>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MenuItemAllergy> MenuItemAllergy { get; set; }
    }
}
