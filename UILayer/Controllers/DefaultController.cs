using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}
