using System;
using MediatR;

namespace SimpleCms.Core
{
    public interface IDomainEvent : INotification
    {
        int EventVersion { get; set; }
        DateTime OccurredOn { get; set; }
    }
}