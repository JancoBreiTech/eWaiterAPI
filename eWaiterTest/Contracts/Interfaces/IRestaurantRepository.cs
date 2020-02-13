using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces
{
    public interface IRestaurantRepository: IRepositoryBase<Restaurant>
    {
        IEnumerable<Restaurant> GetRestaurants();
        Restaurant GetRestaurantById(Guid restaurantId);
        Restaurant GetRestaurantWithFoodTypes(Guid restaurantId);
    }
}
