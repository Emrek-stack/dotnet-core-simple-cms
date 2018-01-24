using System;
using SimpleCms.Core;

namespace SimpleCms.BlogContext.Core.Domain
{
    public class BlogCreated : IDomainEvent
    {
        public int EventVersion { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}