using AutoMapper;
using Models.DataTransferObjects;
using Models.DataTransferObjects.Create;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWaiterTest
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //GetAll
            CreateMap<Restaurant, RestaurantDto>();

            CreateMap<FoodType, FoodTypeDto>();
            CreateMap<RestaurantType, RestaurantTypeDto>();
            CreateMap<RestaurantImg, RestaurantImgDto>();
            CreateMap<Advertisement, AdvertisementDto>();
 
            CreateMap<Restaurant, RestaurantDto>();

            CreateMap<RestaurantForCreationDto, Restaurant>();
        }
    }
}
