using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Shift
    {
        public Shift()
        {
            StaffShift = new HashSet<StaffShift>();
        }

        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int PlannedShiftId { get; set; }

        public virtual PlannedShift PlannedShift { get; set; }
        public virtual ICollection<StaffShift> StaffShift { get; set; }
    }
}
