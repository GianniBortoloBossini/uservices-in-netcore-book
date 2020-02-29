using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ch1HelloMicroservices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrentDateTimeController : ControllerBase
    {
        private readonly ILogger<CurrentDateTimeController> _logger;

        public CurrentDateTimeController(ILogger<CurrentDateTimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public OkObjectResult Get()
        {
            return new OkObjectResult(DateTime.UtcNow);
        }
    }
}
