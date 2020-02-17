using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DataTransferObjects.Update
{
    public class RestaurantForUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string WebsiteUrl { get; set; }
        public string SocialMediaAddress { get; set; }
    }
}
