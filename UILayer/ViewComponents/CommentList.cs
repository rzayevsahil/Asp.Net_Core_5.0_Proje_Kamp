using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
