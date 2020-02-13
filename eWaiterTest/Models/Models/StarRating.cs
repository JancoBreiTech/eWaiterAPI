using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class StarRating
    {
        public StarRating()
        {
            RestaurantUserComment = new HashSet<RestaurantUserComment>();
        }

        public int Id { get; set; }
        public int StarValue { get; set; }

        public virtual ICollection<RestaurantUserComment> RestaurantUserComment { get; set; }
    }
}
