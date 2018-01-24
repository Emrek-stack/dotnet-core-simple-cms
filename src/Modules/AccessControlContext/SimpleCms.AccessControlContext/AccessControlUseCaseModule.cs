using Autofac;
using SimpleCms.Core;
using SimpleCms.Infrastructure.EfCore;
using SimpleCms.AccessControlContext.Infrastructure;

namespace SimpleCms.AccessControl
{
    public class AccessControlUseCaseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            // security context
            builder.RegisterType<SecurityContextProvider>()
                .As<ISecurityContext>()
                .As<ISecurityContextPrincipal>()
                .InstancePerLifetimeScope();

            builder.Register(x =>
                DbContextHelper.BuildDbContext<IdentityServerDbContext>(
                    x.ResolveKeyed<string>("MainDbConnectionString")))
                .SingleInstance();

            builder.RegisterType<UserRepository>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}