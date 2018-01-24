using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SimpleCms.BlogContext.Infrastructure;
using SimpleCms.Infrastructure.EfCore;

namespace SimpleCms.Migrator
{
    public class BlogDbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
    {
        public BlogDbContext CreateDbContext(string[] args)
        {
            return new BlogDbContext(
                new DbContextOptionsBuilder<BlogDbContext>().BuildSqlServerDbContext(
                    typeof(BlogDbContextFactory).GetTypeInfo().Assembly).Options);
        }
    }
}