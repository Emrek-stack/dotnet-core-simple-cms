using Autofac;
using SimpleCms.Infrastructure.EfCore;
using SimpleCms.PostContext.Infrastructure;
using SimpleCms.PostContext.UseCases.ListOutPostByBlog;

namespace SimpleCms.PostContext
{
    public class PostUseCaseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register(x =>
                DbContextHelper.BuildDbContext<PostDbContext>(
                    x.ResolveKeyed<string>("MainDbConnectionString")))
                .SingleInstance();

            builder.RegisterType<ListOutPostByBlogInteractor>()
                .AsSelf()
                .SingleInstance();

            builder.RegisterType<ListOutPostByBlogPresenter>()
                .AsSelf()
                .SingleInstance();
        }
    }
}