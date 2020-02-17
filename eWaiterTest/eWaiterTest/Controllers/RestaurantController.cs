using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DataTransferObjects;
using Models.DataTransferObjects.Create;
using Models.DataTransferObjects.Update;
using Models.Models;

namespace eWaiterTest.Controllers
{
    [Route("api/restaurant")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        //injecting logging and Repository Interfaces
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository; //Houses all repository Interfaces
        private IMapper _mapper;

        public RestaurantController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRestaurants()
        {
            try
            {
                _logger.LogInfo("Fetching all the Restaurants from the storage");
                var restaurants = await _repository.Restaurant.GetRestaurants();
                var restaurantResult = _mapper.Map<IEnumerable<RestaurantDto>>(restaurants);
                _logger.LogInfo($"Returning {restaurants.Count()} restaurants");
                return Ok(restaurantResult);
            }
            catch
            {
                throw new Exception("Exception while fetching restaurants from db");
            }  
           
        }

        [HttpGet("{id}", Name = "RestaurantById")]
        public async Task<IActionResult> GetRestaurantById(int id)
        {
            try
            {
                var restaurant =await _repository.Restaurant.GetRestaurantById(id);

                if (restaurant == null)
                {
                    _logger.LogError($"Restaurant with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned restaurant with id: {id}");

                    var restaurantResult = _mapper.Map<RestaurantDto>(restaurant);
                    return Ok(restaurantResult);
                }
            }
            catch
            {
                throw new Exception($"Exception while fetching restaurant with {id} from db");
            }
        }
        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetRestaurantWithDetails(int id)
        {
            try
            {
                var restaurant = await _repository.Restaurant.GetRestaurantWithDetails(id);

                if (restaurant == null)
                {
                    _logger.LogError($"Restaurant with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned restaurant with details for id: {id}");

                    var result = _mapper.Map<RestaurantDto>(restaurant);
                    return Ok(result);
                }
            }
            catch
            {
                throw new Exception($"Exception while fetching restaurant details with {id} from db");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateRestaurant([FromBody] RestaurantForCreationDto restaurant)
        {
            try
            {
                if (restaurant == null)
                {
                    _logger.LogError("Restaurant object sent from client is null.");
                    return BadRequest("Restaurant object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid restaurant object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var restaurantEntity = _mapper.Map<Restaurant>(restaurant);


                _repository.Restaurant.CreateRestaurant(restaurantEntity);
                await _repository.Save();

                var createdRestaurant = _mapper.Map<RestaurantDto>(restaurantEntity);

                return CreatedAtRoute("RestaurantById", new { id = createdRestaurant.Id }, createdRestaurant);
            }
            catch 
            {
                throw new Exception("Exception while creating restaurant");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRestaurant(int id, [FromBody] RestaurantForUpdateDto restaurant)
        {
            try
            {
                if (restaurant == null)
                {
                    _logger.LogError("Restaurant object sent from client is null.");
                    return BadRequest("Restaurant object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid restaurant object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var restaurantEntity = await _repository.Restaurant.GetRestaurantById(id);
                if (restaurantEntity == null)
                {
                    _logger.LogError($"Restaurant with id: {id}, has not been found in the db.");
                    return NotFound();
                }

                _mapper.Map(restaurant, restaurantEntity);
                _repository.Restaurant.UpdateRestaurant(restaurantEntity);
                await _repository.Save();

                return NoContent();
            }
            catch
            {
                throw new Exception("Exception while updating restaurant from db");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            try
            {
                var restaurant = await _repository.Restaurant.GetRestaurantById(id);
                if (restaurant == null)
                {
                    _logger.LogError($"Restaurant with id: {id}, has not been found in the db.");
                    return NotFound();
                }

                if (_repository.Advertisement.AdvertisementsByRestaurant(id).Any() || 
                    _repository.FoodType.FoodTypesByRestaurant(id).Any() ||
                    _repository.RestaurantImg.RestaurantImgsByRestaurant(id).Any() ||
                    _repository.RestaurantType.RestaurantTypesByRestaurant(id).Any())
                {

                    _logger.LogError($"Cannot delete restaurant with id: {id}. It has related records. Delete those records first");
                    return BadRequest("Cannot delete restaurant. It has related records. Delete those records first");
                }

                _repository.Restaurant.DeleteRestaurant(restaurant);
                await _repository.Save();

                return NoContent();
            }
            catch 
            {
                throw new Exception("Exception while deleting restaurant from db");
            }
        }
    }
}