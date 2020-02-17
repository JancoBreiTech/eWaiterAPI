using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IRestaurantRepository Restaurant { get;}
        IAdvertisement Advertisement { get; }
        IRestaurantImg RestaurantImg { get; }
        IRestaurantType RestaurantType { get; }
        IFoodType FoodType { get; }
        Task Save();
    }
}
