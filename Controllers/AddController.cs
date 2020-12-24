using Microsoft.AspNetCore.Mvc;

namespace aaas.net.Controllers
{
    [Route("add")]
    [ApiController]
    public class AddController : ControllerBase
    {
        [HttpGet("{a}/{b}")]
        public ActionResult<int> AddNumbers(int a, int b)
        {
            if (a < 0 || a > 9 || b < 0 || b > 9)
            {
                return BadRequest("Can only add numbers between 0 and 9, inclusive.");
            }

            return Ok(a + b);
        }
    }
}