using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCms.Infrastructure.AspNetCore
{
    [Authorize]
    public class AuthorizedController : Controller
    {
    }
}