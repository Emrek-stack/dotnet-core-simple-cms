using SimpleCms.Core;
using MediatR;

namespace SimpleCms.BlogContext.UseCases.ListOutBlogByOwner
{
    public class ListOutBlogByOwnerRequest : IRequest<PaginatedItem<ListOutBlogByOwnerResponse>>
    {
    }
}