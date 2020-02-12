using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class CustomerPaymentMethod
    {
        public Guid CustomerId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid PlacedOrderId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PlacedOrder PlacedOrder { get; set; }
    }
}
