using Microsoft.AspNetCore.Mvc;
using SaverAPI.Filters;

namespace SaverAPI.Controllers.V1
{
    [ApiKeyAuth]
    public class SecretController : ControllerBase
    {
        [HttpGet("secret")]
        public IActionResult GetSecret()
        {
            return Ok("I have no secrets");
        }
    }
}