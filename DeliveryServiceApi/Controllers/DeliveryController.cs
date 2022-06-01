using Microsoft.AspNetCore.Mvc;

namespace DeliveryServiceApi.Controllers
{
    [Route(template:"api/[controller]")]
    [Controller]
    public class DeliveryController : Controller
    {
        [HttpGet(template:"check-status")]
        public IActionResult CheckStatus()
        {
            return Ok("Active");
        }
    }
}
