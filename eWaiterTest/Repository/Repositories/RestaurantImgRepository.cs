using Contracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class RestaurantImgRepository: RepositoryBase<RestaurantImg>, IRestaurantImg
    {
        public RestaurantImgRepository(eWaiterTestContext context):base(context)
        {

        }

        public IEnumerable<RestaurantImg> GetAllRestaurantImages()
        {
            return FindAll()
                .OrderBy(r => r.RestaurantId)
                .ToList();
        }

        public IEnumerable<RestaurantImg> RestaurantImgsByRestaurant(int restaurantId)
        {
            return FindByCondition(a => a.RestaurantId.Equals(restaurantId)).ToList();

        }
    }
}
