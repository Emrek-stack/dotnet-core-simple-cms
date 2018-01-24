using SimpleCms.Core;
using Microsoft.EntityFrameworkCore;

namespace SimpleCms.Infrastructure.EfCore
{
    public interface IEfRepository<TDbContext, TEntity> : IRepository<TEntity>
        where TDbContext : DbContext
        where TEntity : EntityBase
    {
        TDbContext DbContext { get; }
    }
}