using Microsoft.AspNetCore.Mvc;

namespace Psychic.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
