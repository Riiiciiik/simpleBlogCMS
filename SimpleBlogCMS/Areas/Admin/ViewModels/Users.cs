using System.Collections;
using System.Collections.Generic;
using SimpleBlogCMS.Models;

namespace SimpleBlogCMS.Areas.Admin.ViewModels
{
    public class UsersIndex
    {
         public IEnumerable<User> Users { get; set; }
    }
}