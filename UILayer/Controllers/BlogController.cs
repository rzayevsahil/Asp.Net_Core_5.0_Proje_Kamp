using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
