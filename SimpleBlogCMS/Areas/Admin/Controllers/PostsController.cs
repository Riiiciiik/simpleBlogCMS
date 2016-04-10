using System;
using System.Linq;
using System.Web.Mvc;
using NHibernate.Linq;
using SimpleBlogCMS.Areas.Admin.ViewModels;
using SimpleBlogCMS.Infrastructure;
using SimpleBlogCMS.Models;

namespace SimpleBlogCMS.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        private const int PostsPerPage = 5;

        public ActionResult Index(int page = 1)
        {
            var totalPostCount = Database.Session.Query<Post>().Count();

        
            var currentPostPage = Database.Session.Query<Post>()
                .OrderByDescending(c => c.CreatedAt)
                .Skip((page - 1)*PostsPerPage)
                .Take(PostsPerPage)
                .ToList();

            return View(new PostsIndex
            {
                Posts = new PagedData<Post>(currentPostPage, totalPostCount, page, PostsPerPage)
            });
        }
    }
}