using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class OrderComment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDateTime { get; set; }
        public string ComlplaintYn { get; set; }
        public int PlacedOrderId { get; set; }

        public virtual PlacedOrder PlacedOrder { get; set; }
    }
}
