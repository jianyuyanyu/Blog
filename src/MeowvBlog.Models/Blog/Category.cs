﻿using MeowvBlog.Entities;

namespace MeowvBlog.Models.Blog
{
    public class Category : Entity
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 展示名称
        /// </summary>
        public string DisplayName { get; set; }
    }
}