using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
