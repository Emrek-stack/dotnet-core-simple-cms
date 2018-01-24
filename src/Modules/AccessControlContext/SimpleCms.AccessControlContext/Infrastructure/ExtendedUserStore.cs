using SimpleCms.AccessControlContext.Core.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SimpleCms.AccessControlContext.Infrastructure
{
    public class ExtendedUserStore : UserStore<AppUser>
    {
        public ExtendedUserStore(IdentityServerDbContext context, IdentityErrorDescriber describer = null) 
            : base(context, describer)
        {
        }
    }
}