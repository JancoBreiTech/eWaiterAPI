using Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class RestaurantRepository: RepositoryBase<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(eWaiterTestContext context) : base(context)
        {

        }

        public Restaurant GetRestaurantById(Guid restaurantId)
        {
            return FindByCondition(r => r.Id == restaurantId)
                .FirstOrDefault();
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return FindAll()
                .OrderBy(r => r.Name)
                .ToList();
        }

        public Restaurant GetRestaurantWithFoodTypes(Guid restaurantId)
        {
            return FindByCondition(r => r.Id.Equals(restaurantId))
                .Include(f => f.FoodType)
                .Include(adv => adv.Advertisement)
                .Include(ri => ri.RestaurantImg)
                .Include(rt => rt.RestaurantType)
                .FirstOrDefault();
        }
    }
}
