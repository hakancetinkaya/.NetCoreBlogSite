using Microsoft.AspNetCore.Mvc;
using MyBlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogSite.ViewComponents
{
    public class CommentList : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            var commentVal = new List<UserComment>
        {
            new UserComment{
            Id=1,
            UserName="ghfhhg",
            },
            new UserComment
            {
                Id=2,
                UserName="fgfgfgfg",
            }
          };
            return View(commentVal);
        }
    }
}
