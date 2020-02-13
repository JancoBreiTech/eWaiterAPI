﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DataTransferObjects.Create
{
    public class RestaurantForCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string WebsiteUrl { get; set; }
        public string SocialMediaAddress { get; set; }

        /*public virtual ICollection<FoodTypeDto> FoodType { get; set; }
        public virtual ICollection<RestaurantTypeDto> RestaurantType { get; set; }
        public virtual ICollection<RestaurantImgDto> RestaurantImg { get; set; }
        public virtual ICollection<AdvertisementDto> Advertisement { get; set; }*/
    }
}
