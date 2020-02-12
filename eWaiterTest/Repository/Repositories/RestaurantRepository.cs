using Contracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class RestaurantRepository: RepositoryBase<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(eWaiterTestContext context) : base(context)
        {

        }
    }
}
