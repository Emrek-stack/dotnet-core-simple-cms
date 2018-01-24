using SimpleCms.Infrastructure.EfCore;
using SimpleCms.PostContext.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace SimpleCms.Migrator
{
    public class PostDbContextFactory : IDesignTimeDbContextFactory<PostDbContext>
    {
        public PostDbContext CreateDbContext(string[] args)
        {
            return new PostDbContext(
                new DbContextOptionsBuilder<PostDbContext>().BuildSqlServerDbContext(
                    typeof(PostDbContextFactory).GetTypeInfo().Assembly).Options);
        }
    }
}