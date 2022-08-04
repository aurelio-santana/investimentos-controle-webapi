using Microsoft.AspNetCore.Mvc;

namespace investAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReitController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Fiis");
        }
    }
}
