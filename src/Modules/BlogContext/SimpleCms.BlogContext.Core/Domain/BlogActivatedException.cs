using System;
using SimpleCms.Core;

namespace SimpleCms.BlogContext.Core.Domain
{
    public class BlogActivatedException : CoreException
    {
        public BlogActivatedException(string message)
            : this(message, null)
        {
        }

        public BlogActivatedException(string message, Exception innerEx)
            : base(message, innerEx)
        {
        }
    }
}