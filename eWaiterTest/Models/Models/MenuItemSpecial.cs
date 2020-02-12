using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MenuItemSpecial
    {
        public Guid SpecialId { get; set; }
        public Guid MenuItemId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual Special Special { get; set; }
    }
}
