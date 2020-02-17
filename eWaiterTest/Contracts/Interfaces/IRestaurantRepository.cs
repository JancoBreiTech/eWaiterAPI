using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface IRestaurantRepository: IRepositoryBase<Restaurant>
    {
        Task<IEnumerable<Restaurant>> GetRestaurants();
        Task<Restaurant> GetRestaurantById(int restaurantId);
        Task<Restaurant> GetRestaurantWithDetails(int restaurantId);
        void CreateRestaurant(Restaurant restaurant);
        void UpdateRestaurant(Restaurant restaurant);
        void DeleteRestaurant(Restaurant restaurant);
    }
}
