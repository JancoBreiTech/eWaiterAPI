using Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class RestaurantRepository: RepositoryBase<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(eWaiterTestContext context) : base(context)
        {

        }

        public void CreateRestaurant(Restaurant restaurant)
        {
            Create(restaurant);
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            Delete(restaurant);
        }

        public async Task<Restaurant> GetRestaurantById(int restaurantId)
        {
            return await FindByCondition(r => r.Id == restaurantId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurants()
        {
            return await FindAll()
                .OrderBy(r => r.Name)
                .ToListAsync();
        }

        public async Task<Restaurant> GetRestaurantWithDetails(int restaurantId)
        {
            return await FindByCondition(r => r.Id.Equals(restaurantId))
                .Include(f => f.FoodType)
                .Include(adv => adv.Advertisement)
                .Include(ri => ri.RestaurantImg)
                .Include(rt => rt.RestaurantType)
                .FirstOrDefaultAsync();
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            Update(restaurant); ;
        }
    }
}
