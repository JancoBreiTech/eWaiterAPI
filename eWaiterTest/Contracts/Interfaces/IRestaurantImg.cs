using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces
{
    public interface IRestaurantImg: IRepositoryBase<RestaurantImg>
    {
        IEnumerable<RestaurantImg> GetAllRestaurantImages();
        IEnumerable<RestaurantImg> RestaurantImgsByRestaurant(int restaurantId);

    }
}
