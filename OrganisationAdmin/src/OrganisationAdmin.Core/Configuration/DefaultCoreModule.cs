using Autofac;
using OrganisationAdmin.Core.Concretions.Services.Domain;
using OrganisationAdmin.Core.Interfaces.Services.Domain;

namespace OrganisationAdmin.Core.Configuration;

public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<IPostcodeLocationClientService>().As<PostcodeLocationClientService>().InstancePerLifetimeScope();
    }
}