using Contracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class RestaurantImgRepository: RepositoryBase<RestaurantImg>, IRestaurantImg
    {
        public RestaurantImgRepository(eWaiterTestContext context):base(context)
        {

        }
    }
}
