using SimpleCms.Core;
using SimpleCms.Infrastructure.UseCase;
using System;

namespace SimpleCms.PostContext.UseCases.ListOutPostByBlog
{
    public class ListOutPostByBlogRequest : IRequest<PaginatedItem<ListOutPostByBlogResponse>>
    {
        public ListOutPostByBlogRequest(Guid blogId, int page)
        {
            BlogId = blogId;
            Page = page;
        }

        public Guid BlogId { get; private set; }
        public int Page { get; private set; }
    }
}