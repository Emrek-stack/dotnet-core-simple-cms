using SimpleCms.Core;
using System;

namespace SimpleCms.PostContext.Core.Domain
{
    public class NotFoundCommentException : CoreException
    {
        public NotFoundCommentException(string message)
            : this(message, null)
        {
        }

        public NotFoundCommentException(string message, Exception innerEx)
            : base(message, innerEx)
        {
        }
    }
}