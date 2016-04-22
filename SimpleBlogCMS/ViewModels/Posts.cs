﻿using SimpleBlogCMS.Infrastructure;
using SimpleBlogCMS.Models;

namespace SimpleBlogCMS.ViewModels
{
    public class PostsIndex
    {
         public PagedData<Post> Posts { get; set; }

    }

    public class PostsShow
    {
        public Post Post { get; set; }
    }

    public class PostsTag
    {
        public Tag Tag { get; set; }
        public PagedData<Post> Posts { get; set; } 

    }
}