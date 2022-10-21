using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var blogCount = categoryManager.TGetList().Select(x=>x.Blogs.Count());
            ViewBag.blogCount = blogCount;
            var values = categoryManager.TGetList();
            return View(values);
        }
    }
}
