﻿using Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class FoodTypeRepository: RepositoryBase<FoodType>, IFoodType
    {
        public FoodTypeRepository(eWaiterTestContext context): base(context)
        {

        }

        public IEnumerable<FoodType> GetAllFoodTypes()
        {
            return FindAll()
                .OrderBy(f => f.Description)
                .ToList();
        }

        public FoodType GetAllRestaurantsByFoodType(Guid foodTypeId)
        {
            return FindByCondition(f => f.Id.Equals(foodTypeId))
                .Include(r => r.Restaurant)
                .FirstOrDefault();
        }
    }
}
