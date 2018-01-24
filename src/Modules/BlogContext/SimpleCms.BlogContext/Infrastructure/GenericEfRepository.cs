using SimpleCms.Core;
using SimpleCms.Infrastructure.EfCore;

namespace SimpleCms.BlogContext.Infrastructure
{
    public class BlogEfRepository<TEntity> : EfRepository<BlogDbContext, TEntity>
        where TEntity : EntityBase
    {
        public BlogEfRepository(BlogDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}