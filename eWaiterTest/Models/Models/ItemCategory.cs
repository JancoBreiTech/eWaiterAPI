using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ItemCategory
    {
        public ItemCategory()
        {
            MenuItem = new HashSet<MenuItem>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MenuItem> MenuItem { get; set; }
    }
}
