using System.Linq;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents.Blog
{
    public class WriterLastBlogs : ViewComponent
    {
        IBlogService _blogService;
        public WriterLastBlogs(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _blogService.TGetLastThreeBlogListByWriter(1);
            return View(values);
        }
    }
}
