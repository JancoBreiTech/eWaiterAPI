using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eWaiterTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantImgController : ControllerBase
    {
        //injecting logging and Repository Interfaces
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository; //Houses all repository Interfaces

        public RestaurantImgController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public IActionResult GetAllRestaurantImages()
        {
            try
            {
                var img = _repository.RestaurantImg.GetAllRestaurantImages();
                _logger.LogInfo($"Successfully returned all Restaurant Images.");
                return Ok(img);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in GetAllRestaurantImages(): {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
            
        }
    }
}