using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly ILogger<InventoryController> _logger;

        public InventoryController(ILogger<InventoryController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        [Route("export")]
        public IActionResult Export(InventoryModel model)
        {
            _logger.LogInformation("Start Export product");
            // your logic here
            if (model.Quantity < 1)
            {
                _logger.LogError("End Export product with something went wrong");
                return BadRequest();
            }
            _logger.LogInformation("End Export product");
            return Ok();
        }
    }
}