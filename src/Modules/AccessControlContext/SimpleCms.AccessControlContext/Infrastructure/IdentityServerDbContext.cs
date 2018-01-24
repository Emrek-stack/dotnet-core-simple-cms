using SimpleCms.AccessControlContext.Core.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SimpleCms.AccessControlContext.Infrastructure
{
    public class IdentityServerDbContext : IdentityDbContext<AppUser>
    {
        public IdentityServerDbContext(DbContextOptions<IdentityServerDbContext> options)
            : base(options)
        {
        }
    }
}
