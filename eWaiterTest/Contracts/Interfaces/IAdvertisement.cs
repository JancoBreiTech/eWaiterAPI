using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces
{
    public interface IAdvertisement: IRepositoryBase<Advertisement>
    {
        IEnumerable<Advertisement> GetAllAdvertisements();
        IEnumerable<Advertisement> AdvertisementsByRestaurant(int restaurantId);
    }
}
