using System;
using System.Collections.Generic;
using SimpleCms.BlogContext.Core.Domain;
using SimpleCms.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;

namespace SimpleCms.BlogContext.Infrastructure
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var entityTypes = new List<Type>
            {
                typeof(Core.Domain.Blog)
            };

            var valueTypes = new List<Type>
            {
                typeof(BlogSetting)
            };

            base.OnModelCreating(builder.RegisterTypes(entityTypes, valueTypes, "blog", "blog"));
        }
    }
}