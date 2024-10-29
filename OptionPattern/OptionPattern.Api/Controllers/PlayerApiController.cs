using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionPattern.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerApiController : ControllerBase
    {

        private readonly PlayerSettings _playerSettings;
        private readonly IOptions<ApiRetryOptions> _retryOptions;

        public PlayerApiController(IOptions<PlayerSettings> playerSettings, IOptions<ApiRetryOptions> retryOptions)
        {
            _playerSettings = playerSettings.Value;
            _retryOptions = retryOptions;
        }
        [HttpGet("GetPlayerSettings")]
        public ActionResult GetPlayerSettings(){

            return Ok( _playerSettings );
        }
        [HttpGet("GetPlayerHealt")]
        public ActionResult GetPlayerHealt(){

            return Ok( new {Health= _playerSettings.Health});
        }
        [HttpGet("ApiRetryOptions")]
        public ActionResult GetApiRetryOptions(){

            return Ok( new{
                MaxRetries= _retryOptions.Value.MaxRetries,
                DelayInSeconds = _retryOptions.Value.DelayInSeconds
            });
        }
    }
}