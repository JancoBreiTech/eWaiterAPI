using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Staff
    {
        public Staff()
        {
            PlacedOrder = new HashSet<PlacedOrder>();
            StaffShift = new HashSet<StaffShift>();
        }

        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid StaffRoleId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string IdNumber { get; set; }
        public Guid RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual StaffRole StaffRole { get; set; }
        public virtual ICollection<PlacedOrder> PlacedOrder { get; set; }
        public virtual ICollection<StaffShift> StaffShift { get; set; }
    }
}
