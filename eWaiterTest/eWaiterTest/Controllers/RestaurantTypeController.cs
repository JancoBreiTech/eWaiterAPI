﻿using System;
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
    public class RestaurantTypeController : ControllerBase
    {
        //injecting logging and Repository Interfaces
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository; //Houses all repository Interfaces

        public RestaurantTypeController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllRestaurantTypes()
        {
            try
            {
                var types = _repository.RestaurantType.GetAllRestaurantType();
                _logger.LogInfo($"Successfully returned all restaurant types");
                return Ok(types);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in GetAllRestaurantTypes(): {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
            
        }
    }
}