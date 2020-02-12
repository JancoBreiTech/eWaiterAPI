using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PlacedOrder
    {
        public PlacedOrder()
        {
            CustomerPaymentMethod = new HashSet<CustomerPaymentMethod>();
            OrderComment = new HashSet<OrderComment>();
            OrderMenuItem = new HashSet<OrderMenuItem>();
            OrderStatus = new HashSet<OrderStatus>();
        }

        public Guid Id { get; set; }
        public Guid OrderTableId { get; set; }
        public Guid StaffId { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual OrderTable OrderTable { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<CustomerPaymentMethod> CustomerPaymentMethod { get; set; }
        public virtual ICollection<OrderComment> OrderComment { get; set; }
        public virtual ICollection<OrderMenuItem> OrderMenuItem { get; set; }
        public virtual ICollection<OrderStatus> OrderStatus { get; set; }
    }
}
