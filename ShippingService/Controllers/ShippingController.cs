using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShippingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly ILogger<ShippingController> _logger;

        public ShippingController(ILogger<ShippingController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("ship")]
        public IActionResult Ship(ShippingModel model)
        {
            _logger.LogInformation("Start calling Ship method");
            // your logic here
            if (model.Address.Contains("China"))
            {
                _logger.LogError("Something wrong with Ship method");
                return BadRequest();
            }
            _logger.LogInformation("End calling Ship method");
            return Ok();
        }
    }
}