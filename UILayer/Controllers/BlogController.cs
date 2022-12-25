using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class BlogController : Controller
    {
        IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            var values = _blogService.TGetListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.blogID = id;
            var values = _blogService.TGetBlogByID(id);
            return View(values);
        }
    }
}
