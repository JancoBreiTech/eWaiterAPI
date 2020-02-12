using Contracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class RestaurantTypeRepository: RepositoryBase<RestaurantType>, IRestaurantType
    {
        public RestaurantTypeRepository(eWaiterTestContext context) : base(context)
        {

        }
    }
}
