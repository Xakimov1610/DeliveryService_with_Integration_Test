using Microsoft.AspNetCore.Mvc;

namespace DeliveryServiceApi.Controllers
{
    [Route(template:"api/[controller]")]
    [Controller]
    public class DeliveryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
