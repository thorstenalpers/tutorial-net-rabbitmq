using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Producer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly ILogger<MessageController> _logger;

        public MessageController(ILogger<MessageController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Post([FromBody] string message)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get([FromBody] string message)
        {
            return Ok();
        }
    }
}
