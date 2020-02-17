using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces
{
    public interface IFoodType:IRepositoryBase<FoodType>
    {
        IEnumerable<FoodType> GetAllFoodTypes();
        IEnumerable<FoodType> FoodTypesByRestaurant(int restaurantId);
        FoodType GetAllRestaurantsByFoodType(int foodTypeId);

    }
}
