using Contracts;
using Contracts.Interfaces;
using Models.Models;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private eWaiterTestContext _repoContext;
        private IRestaurantRepository _restaurant;
        private IRestaurantType _restaurantType;
        private IAdvertisement _advertisement;
        private IRestaurantImg _resImg;
        private IFoodType _foodType;

        public IRestaurantRepository Restaurant
        {
            get
            {
                if (_restaurant == null)
                {
                    _restaurant = new RestaurantRepository(_repoContext);
                }
                return _restaurant;
            }
        }

        public IAdvertisement Advertisement
        {
            get
            {
                if (_advertisement == null)
                {
                    _advertisement = new AdvertisementRepository(_repoContext);
                }
                return _advertisement;
            }
        }

        public IRestaurantImg RestaurantImg
        {
            get
            {
                if (_resImg == null)
                {
                    _resImg = new RestaurantImgRepository(_repoContext);
                }
                return _resImg;
            }
        }

        public IRestaurantType RestaurantType
        {
            get
            {
                if (_restaurantType == null)
                {
                    _restaurantType = new RestaurantTypeRepository(_repoContext);
                }
                return _restaurantType;
            }
        }

        public IFoodType FoodType
        {
            get
            {
                if (_foodType == null)
                {
                    _foodType = new FoodTypeRepository(_repoContext);
                }
                return _foodType;
            }
        }

        public RepositoryWrapper(eWaiterTestContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public async Task Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
