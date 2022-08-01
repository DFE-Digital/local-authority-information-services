using Ardalis.GuardClauses;
using Autofac;
using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using MediatR;
using OrganisationAdmin.Core.Concretions.Entities.Aggregates;
using OrganisationAdmin.Infrastructure.Persistence.Repository;
using System.Reflection;
using Module = Autofac.Module;

namespace OrganisationAdmin.Infrastructure
{
    public class DefaultInfrastructureModule : Module
    {
        private readonly bool _isDevelopment = false;
        private readonly List<Assembly> _assemblies = new List<Assembly>();

        public DefaultInfrastructureModule(bool isDevelopment, Assembly? callingAssembly = null)
        {
            _isDevelopment = isDevelopment;

            var coreAssembly = Assembly.GetAssembly(typeof(Organization));
            Guard.Against.Null(coreAssembly, nameof(coreAssembly));
            _assemblies.Add(coreAssembly);

            var infrastructureAssembly = Assembly.GetAssembly(typeof(ApplicationDbContext));
            Guard.Against.Null(infrastructureAssembly, nameof(infrastructureAssembly));
            _assemblies.Add(infrastructureAssembly);

            if (callingAssembly != null)
            {
                _assemblies.Add(callingAssembly);
            }
        }

        protected override void Load(ContainerBuilder builder)
        {
            if (_isDevelopment)
            {
                RegisterDevelopmentOnlyDependencies(builder);
            }
            else
            {
                RegisterProductionOnlyDependencies(builder);
            }
            RegisterCommonDependencies(builder);
        }

        private void RegisterDevelopmentOnlyDependencies(ContainerBuilder builder)
        {
            // Add development only services
        }

        private void RegisterProductionOnlyDependencies(ContainerBuilder builder)
        {
            // Add production only services
        }

        private void RegisterCommonDependencies(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(EfRepository<>))
                .As(typeof(IRepository<>))
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(EfRepository<>))
                .InstancePerLifetimeScope();

            // add a cache
            builder.RegisterGeneric(typeof(CachedRepository<>))
              .As(typeof(IReadRepository<>))
                .InstancePerLifetimeScope();

            //builder.RegisterType(typeof(RabbitMessagePublisher))
            //  .As(typeof(IMessagePublisher))
            //  .InstancePerLifetimeScope();

            // MediatR is registered in FrontDesk.Api
            //      builder
            //          .RegisterType<Mediator>()
            //          .As<IMediator>()
            //          .InstancePerLifetimeScope();

            //      var mediatrOpenTypes = new[]
            //{
            //        typeof(IRequestHandler<,>),
            //        typeof(IRequestExceptionHandler<,,>),
            //        typeof(IRequestExceptionAction<,>),
            //        typeof(INotificationHandler<>),
            //      };

            //      foreach (var mediatrOpenType in mediatrOpenTypes)
            //      {
            //        builder
            //        .RegisterAssemblyTypes(_assemblies.ToArray())
            //        .AsClosedTypesOf(mediatrOpenType)
            //        .AsImplementedInterfaces();
            //      }

            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            //builder.RegisterType<EmailSender>().As<IEmailSender>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterType<AppDbContextSeed>().InstancePerLifetimeScope();
        }
    }
}
