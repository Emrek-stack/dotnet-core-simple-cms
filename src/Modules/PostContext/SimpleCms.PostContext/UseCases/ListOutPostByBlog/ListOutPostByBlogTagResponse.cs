using SimpleCms.Core;
using System;

namespace SimpleCms.PostContext.UseCases.ListOutPostByBlog
{
    public class ListOutPostByBlogTagResponse : IMessage
    {
        public ListOutPostByBlogTagResponse(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}