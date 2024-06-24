using APICore.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeConvertorController : ControllerBase
    {

        private readonly ILogger<TimeConvertorController> _logger;

        public TimeConvertorController(ILogger<TimeConvertorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTimeConvertorController")]
        public TimeConvertorModel Get()
        {
            return new TimeConvertorModel
            {
                Date = DateOnly.FromDateTime(DateTime.Now)
            };
        }
    }
}
