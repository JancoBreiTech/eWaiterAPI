using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces
{
    public interface IRestaurantRepository: IRepositoryBase<Restaurant>
    {
        IEnumerable<Restaurant> GetRestaurants();
        Restaurant GetRestaurantById(int restaurantId);
        Restaurant GetRestaurantWithDetails(int restaurantId);
        void CreateRestaurant(Restaurant restaurant);
    }
}
