using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class CommentController : Controller
    {
        private ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult PartialCommentListByBlog(int id)
        {
            var values = _commentService.TGetList(id);
            return PartialView(values);
        }
    }
}
