using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class CustomerPaymentMethod
    {
        public int CustomerId { get; set; }
        public int PaymentMethodId { get; set; }
        public int PlacedOrderId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PlacedOrder PlacedOrder { get; set; }
    }
}
