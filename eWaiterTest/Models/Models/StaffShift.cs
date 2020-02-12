using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class StaffShift
    {
        public Guid StaffId { get; set; }
        public Guid ShiftId { get; set; }

        public virtual Shift Shift { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
