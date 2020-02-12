using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class StatusCatalog
    {
        public StatusCatalog()
        {
            OrderStatus = new HashSet<OrderStatus>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderStatus> OrderStatus { get; set; }
    }
}
