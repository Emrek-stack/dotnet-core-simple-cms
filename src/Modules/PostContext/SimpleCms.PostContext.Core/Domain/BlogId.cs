using SimpleCms.Core;
using System;

namespace SimpleCms.PostContext.Core.Domain
{
    public class BlogId : IdentityBase
    {
        private BlogId()
        {
        }

        public BlogId(Guid blogId) : base(blogId)
        {
        }
    }
}