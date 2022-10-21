using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UILayer.Models;

namespace UILayer.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName = "Sahil"
                },
                new UserComment
                {
                    ID = 2,
                    UserName = "Murat"
                },
                new UserComment
                {
                    ID = 3,
                    UserName = "Ahmet"
                },
            };
            return View(commentValues);
        }
    }
}
