﻿using System.ComponentModel.DataAnnotations;
using SimpleBlogCMS.Infrastructure;
using SimpleBlogCMS.Models;

namespace SimpleBlogCMS.Areas.Admin.ViewModels
{
    public class PostsIndex
    {
         public PagedData<Post> Posts { get; set; } 
    }

    public class PostsForm
    {
        public bool IsNew { get; set; }
        public int? PostId { get; set; }

        [Required, MaxLength(128)]
        public string Title { get; set; }

        [Required, MaxLength(128)]
        public string Slug { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}