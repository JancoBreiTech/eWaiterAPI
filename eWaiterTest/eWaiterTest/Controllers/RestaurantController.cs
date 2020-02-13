using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DataTransferObjects;

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
        public IActionResult GetAllRestaurants()
        {
            try
            {
                //retrieve all restaurants from db
                var restaurants = _repository.Restaurant.GetRestaurants();
                //return log
                _logger.LogInfo($"Returned all owners from database.");
                //map model to DTO
                var restaurantResult = _mapper.Map<IEnumerable<RestaurantDto>>(restaurants);
                //return HttpStatusCode
                return Ok(restaurantResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllOwners(): {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetRestaurantById(Guid id)
        {
            try
            {
                var restaurant = _repository.Restaurant.GetRestaurantById(id);

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
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetRestaurantById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}/details")]
        public IActionResult GetRestaurantWithDetails(Guid id)
        {
            try
            {
                var restaurant = _repository.Restaurant.GetRestaurantWithFoodTypes(id);

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
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetRestaurantWithDetails action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}