using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerPaymentMethod = new HashSet<CustomerPaymentMethod>();
            RestaurantUserComment = new HashSet<RestaurantUserComment>();
            UserTableBooking = new HashSet<UserTableBooking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string ConfirmationCode { get; set; }
        public string ShareInfo { get; set; }
        public string Email { get; set; }

        public virtual ICollection<CustomerPaymentMethod> CustomerPaymentMethod { get; set; }
        public virtual ICollection<RestaurantUserComment> RestaurantUserComment { get; set; }
        public virtual ICollection<UserTableBooking> UserTableBooking { get; set; }
    }
}
