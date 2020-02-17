using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces
{
    public interface IRestaurantType: IRepositoryBase<RestaurantType>
    {
        IEnumerable<RestaurantType> GetAllRestaurantType();
        IEnumerable<RestaurantType> RestaurantTypesByRestaurant(int restaurantId);

    }
}
