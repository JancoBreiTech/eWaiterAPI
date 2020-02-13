using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantUserComment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int StarRatingId { get; set; }
        public int RestaurantId { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual StarRating StarRating { get; set; }
    }
}
