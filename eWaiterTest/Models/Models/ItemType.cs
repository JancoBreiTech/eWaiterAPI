using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            MenuItem = new HashSet<MenuItem>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MenuItem> MenuItem { get; set; }
    }
}
