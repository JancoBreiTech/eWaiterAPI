using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ReorderFrequency
    {
        public ReorderFrequency()
        {
            Ingredient = new HashSet<Ingredient>();
        }

        public Guid Id { get; set; }
        public string Frequency { get; set; }

        public virtual ICollection<Ingredient> Ingredient { get; set; }
    }
}
