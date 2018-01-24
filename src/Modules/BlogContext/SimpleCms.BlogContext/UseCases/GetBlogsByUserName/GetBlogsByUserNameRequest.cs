using SimpleCms.Core;
using SimpleCms.Infrastructure.UseCase;

namespace SimpleCms.BlogContext.UseCases.GetBlogsByUserName
{
    public class GetBlogsByUserNameRequest : IRequest<PaginatedItem<GetBlogsByUserNameResponse>>
    {
        public int Page { get; set; }
        public string UserName { get; set; }
    }
}
