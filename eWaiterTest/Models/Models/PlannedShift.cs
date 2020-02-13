using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PlannedShift
    {
        public PlannedShift()
        {
            Shift = new HashSet<Shift>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }

        public virtual ICollection<Shift> Shift { get; set; }
    }
}
