using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlogCMS.Infrastructure;

namespace SimpleBlogCMS.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}