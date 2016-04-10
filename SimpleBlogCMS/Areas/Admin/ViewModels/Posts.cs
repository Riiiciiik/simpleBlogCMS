using SimpleBlogCMS.Infrastructure;
using SimpleBlogCMS.Models;

namespace SimpleBlogCMS.Areas.Admin.ViewModels
{
    public class PostsIndex
    {
         public PagedData<Post> Posts { get; set; } 
    }
}