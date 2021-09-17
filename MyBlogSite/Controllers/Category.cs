using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogSite.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        { 
            var asa= 3;
            asa = 1;
            return View();
        }
    }
}
