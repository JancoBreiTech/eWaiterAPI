using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            CustomerPaymentMethod = new HashSet<CustomerPaymentMethod>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CustomerPaymentMethod> CustomerPaymentMethod { get; set; }
    }
}
