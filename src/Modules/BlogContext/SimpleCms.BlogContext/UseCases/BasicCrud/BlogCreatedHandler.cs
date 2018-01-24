using SimpleCms.BlogContext.Core.Domain;
using MediatR;

namespace SimpleCms.BlogContext.UseCases.BasicCrud
{
    public class BlogSettingChangedHandler : INotificationHandler<BlogCreated>
    {
        public void Handle(BlogCreated notification)
        {
            // TODO: send an email to notify for administrator
            // TODO: ...
        }
    }
}