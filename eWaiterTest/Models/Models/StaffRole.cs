using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class StaffRole
    {
        public StaffRole()
        {
            Staff = new HashSet<Staff>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal HourlyRate { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
