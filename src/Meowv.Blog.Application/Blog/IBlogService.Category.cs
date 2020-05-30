﻿using Meowv.Blog.Application.Contracts.Blog;
using Meowv.Blog.ToolKits.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meowv.Blog.Application.Blog
{
    public partial interface IBlogService
    {
        /// <summary>
        /// 查询分类列表
        /// </summary>
        /// <returns></returns>
        Task<ServiceResult<IEnumerable<QueryCategoryDto>>> QueryCategoriesAsync();
    }
}