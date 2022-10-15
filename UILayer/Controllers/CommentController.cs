using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult PartialCommentListByBlog() 
        {
            return PartialView();
        }
    }
}
