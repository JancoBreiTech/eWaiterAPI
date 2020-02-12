using Contracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class FoodTypeRepository: RepositoryBase<FoodType>, IFoodType
    {
        public FoodTypeRepository(eWaiterTestContext context): base(context)
        {

        }
    }
}
