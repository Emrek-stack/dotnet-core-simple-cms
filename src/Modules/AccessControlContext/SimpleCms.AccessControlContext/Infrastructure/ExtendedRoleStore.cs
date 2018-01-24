using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SimpleCms.AccessControlContext.Infrastructure
{
    public class ExtendedRoleStore : RoleStore<IdentityRole>
    {
        public ExtendedRoleStore(IdentityServerDbContext context, IdentityErrorDescriber describer = null)
            : base(context, describer)
        {
        }
    }
}