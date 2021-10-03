using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogSite.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var list = bm.GetBlogListWithCategory();
            return View(list);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var res = bm.GetBlogById(id);
            return View(res);
        }
    }
}
