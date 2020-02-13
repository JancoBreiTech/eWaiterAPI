using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class OrderStatus
    {
        public int PlacedOrderId { get; set; }
        public int StatusCatalogId { get; set; }
        public DateTime DateChanged { get; set; }

        public virtual PlacedOrder PlacedOrder { get; set; }
        public virtual StatusCatalog StatusCatalog { get; set; }
    }
}
