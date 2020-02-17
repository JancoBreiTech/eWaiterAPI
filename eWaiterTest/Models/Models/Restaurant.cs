using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Advertisement = new HashSet<Advertisement>();
            FoodType = new HashSet<FoodType>();
            Menu = new HashSet<Menu>();
            RestaurantAddress = new HashSet<RestaurantAddress>();
            RestaurantFacility = new HashSet<RestaurantFacility>();
            RestaurantImg = new HashSet<RestaurantImg>();
            RestaurantSeating = new HashSet<RestaurantSeating>();
            RestaurantType = new HashSet<RestaurantType>();
            Staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string WebsiteUrl { get; set; }
        public string SocialMediaAddress { get; set; }

        public virtual ICollection<Advertisement> Advertisement { get; set; }
        public virtual ICollection<FoodType> FoodType { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<RestaurantAddress> RestaurantAddress { get; set; }
        public virtual ICollection<RestaurantFacility> RestaurantFacility { get; set; }
        public virtual ICollection<RestaurantImg> RestaurantImg { get; set; }
        public virtual ICollection<RestaurantSeating> RestaurantSeating { get; set; }
        public virtual ICollection<RestaurantType> RestaurantType { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
