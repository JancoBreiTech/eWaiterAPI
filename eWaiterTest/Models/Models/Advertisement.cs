﻿using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Advertisement
    {
        public int Id { get; set; }
        public DateTime? DateActiveFrom { get; set; }
        public DateTime? DateActiveTo { get; set; }
        public decimal? Price { get; set; }
        public byte[] AdvFile { get; set; }
        public string TargetAudience { get; set; }
        public int? RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
