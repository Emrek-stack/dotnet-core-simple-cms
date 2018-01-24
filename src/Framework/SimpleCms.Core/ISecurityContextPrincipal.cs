using System.Security.Claims;

namespace SimpleCms.Core
{
    public interface ISecurityContextPrincipal
    {
        ClaimsIdentity Claims { set; }
        void SetBlog(EntityBase blog);
    }
}