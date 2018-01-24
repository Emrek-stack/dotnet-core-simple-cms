using SimpleCms.Core;
using SimpleCms.Infrastructure.EfCore;

namespace SimpleCms.PostContext.Infrastructure
{
    public class BlogEfRepository<TEntity> : EfRepository<PostDbContext, TEntity>
        where TEntity : EntityBase
    {
        public BlogEfRepository(PostDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}