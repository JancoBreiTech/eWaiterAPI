using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MenuItemSpecial
    {
        public int SpecialId { get; set; }
        public int MenuItemId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual Special Special { get; set; }
    }
}
