using Contracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class RestaurantTypeRepository: RepositoryBase<RestaurantType>, IRestaurantType
    {
        public RestaurantTypeRepository(eWaiterTestContext context) : base(context)
        {

        }

        public IEnumerable<RestaurantType> GetAllRestaurantType()
        {
            return FindAll()
                .OrderBy(r => r.Description)
                .ToList();
        }

        public IEnumerable<RestaurantType> RestaurantTypesByRestaurant(int restaurantId)
        {
            return FindByCondition(a => a.RestaurantId.Equals(restaurantId)).ToList();

        }
    }
}
