using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OptionPattern.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        
        private const string TIMEOUT_CONFIG = "Timeout";
        [HttpGet("GetOption")]
        public int GetOption(IConfiguration configuration)
        {
            var value= configuration.GetValue(TIMEOUT_CONFIG,-1);
            return value;
        }
    }
}