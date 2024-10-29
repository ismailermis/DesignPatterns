using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionPattern.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrentOptionApiController : ControllerBase
    {
        private readonly IOptionsMonitor<AppSettings> _appMonitorSettings;
        private readonly IOptionsSnapshot<AppSettings> _appSettings;
        public CurrentOptionApiController(IOptionsSnapshot<AppSettings> appSettings,
         IOptionsMonitor<AppSettings> appMonitorSettings)
        {
            _appSettings = appSettings;
            _appMonitorSettings = appMonitorSettings;
        }
        [HttpGet("GetCurrentPlayerSettings")]
        public ActionResult GetPlayerSettings()
        {

            return Ok(_appMonitorSettings);
        }
        [HttpGet("GetApiKey")]
        public string GetApiKey()
        {
            return _appSettings.Value.ApiKey;
        }
        [HttpGet("GetMaxItemsPerPage")]

        public int GetMaxItemsPerPage()
        {
            return _appSettings.Value.MaxItemsPerPage;
        }
    }
}