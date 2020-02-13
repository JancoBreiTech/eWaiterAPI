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
    [Route("api/[controller]")]
    [ApiController]
    public class FoodTypeController : ControllerBase
    {
        //injecting logging and Repository Interfaces
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository; //Houses all repository Interfaces
        private IMapper _mapper;

        public FoodTypeController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllFoodTypes()
        {
            try
            {
                var foodTypes = _repository.FoodType.GetAllFoodTypes();

                _logger.LogInfo($"Successfully returned all food types");
                var foodTypesResult = _mapper.Map <IEnumerable<FoodTypeDto>>(foodTypes);

                return Ok(foodTypesResult);

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in GetAllFoodTypes(): {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAllRestaurantsByFoodType(int id)
        {
            try
            {
                var foodType = _repository.FoodType.GetAllRestaurantsByFoodType(id);

                if (foodType == null)
                {
                    _logger.LogError($"Food Type details with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned food type details with id: {id}");

                    var result = _mapper.Map<FoodTypeDto>(foodType);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllRestaurantsByFoodType action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}