using Microsoft.AspNetCore.Mvc;

namespace OrbitOps.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("OrbitOps API is running");
        }
    }
}