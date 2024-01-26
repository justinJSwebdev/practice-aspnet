using Microsoft.AspNetCore.Mvc;
using b.Model;
namespace b.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
            return Json(person.ToString());
        }
    }
}
