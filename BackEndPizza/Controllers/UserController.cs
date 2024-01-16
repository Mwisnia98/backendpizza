using Microsoft.AspNetCore.Mvc;

namespace BackEndPizza.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("chwdp");
        }
    }
}