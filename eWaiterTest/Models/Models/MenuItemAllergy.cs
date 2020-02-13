using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MenuItemAllergy
    {
        public int MenuItemId { get; set; }
        public int AllergyId { get; set; }

        public virtual Allergy Allergy { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
