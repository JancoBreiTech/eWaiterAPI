using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ItemStatus
    {
        public ItemStatus()
        {
            MenuItem = new HashSet<MenuItem>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime? DateActiveFrom { get; set; }
        public DateTime? DateActiveTo { get; set; }

        public virtual ICollection<MenuItem> MenuItem { get; set; }
    }
}
