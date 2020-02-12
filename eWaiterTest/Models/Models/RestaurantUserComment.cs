using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RestaurantUserComment
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid StarRatingId { get; set; }
        public Guid RestaurantId { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual StarRating StarRating { get; set; }
    }
}
