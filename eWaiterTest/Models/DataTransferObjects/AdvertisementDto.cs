using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DataTransferObjects
{
    public class AdvertisementDto
    {
        public int Id { get; set; }
        public DateTime? DateActiveFrom { get; set; }
        public DateTime? DateActiveTo { get; set; }
        public decimal? Price { get; set; }
        public byte[] AdvFile { get; set; }
        public string TargetAudience { get; set; }
    }
}
