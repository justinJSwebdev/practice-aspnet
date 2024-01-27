using Microsoft.AspNetCore.Mvc;
using b.Model;
namespace b.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                List<string> errors = new List<string>();
                foreach(var value in ModelState.Values)
                {
                    foreach(var error in value.Errors)
                    {
                        errors.Add(error);
                    }
                }
                if(errors.Count > 0)
                {
                    return Json(
                        string.Join("", errors)
                    );
                }
            }
            return Json(person.ToString());
        }
    }
}
