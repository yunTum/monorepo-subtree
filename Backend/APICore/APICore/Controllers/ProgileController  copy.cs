using APICore.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTest")]
        public TestModel Get()
        {
            return new TestModel
            {
                Name = "Taro",
            };
        }
    }
}
