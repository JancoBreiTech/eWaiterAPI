using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class OrderComment
    {
        public Guid Id { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDateTime { get; set; }
        public string ComlplaintYn { get; set; }
        public Guid PlacedOrderId { get; set; }

        public virtual PlacedOrder PlacedOrder { get; set; }
    }
}
