using Microsoft.AspNetCore.Mvc;

namespace investAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Ações");
        }
    }
}
