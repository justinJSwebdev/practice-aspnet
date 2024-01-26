using Microsoft.AspNetCore.Mvc;

namespace b.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public IActionResult Index()
        {
            return Json("Hello");
        }
    }
}
