using Microsoft.AspNetCore.Mvc;
using b.Model;
namespace b.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Json("Hello");
        }
  
    }
}
