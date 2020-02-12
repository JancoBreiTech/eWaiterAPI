using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eWaiterTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private IRepositoryWrapper _repoWrapper;

        public WeatherForecastController(ILoggerManager logger, IRepositoryWrapper repoWrapper)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        { 

            return new string[] { "value1", "value2" };
        }
    }
}
