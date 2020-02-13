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
    public class AdvertisementController : ControllerBase
    {
        //injecting logging and Repository Interfaces
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository; //Houses all repository Interfaces

        public AdvertisementController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllAdvertisements()
        {
            try
            {
                var adv = _repository.Advertisement.GetAllAdvertisements();
                _logger.LogInfo($"Successfully returned all advertisements");
                return Ok(adv);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in GetAllAdvertisements(): {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}