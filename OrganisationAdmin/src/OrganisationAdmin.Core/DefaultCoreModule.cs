using Autofac;
using OrganisationAdmin.Core.Interfaces;
using OrganisationAdmin.Core.Services;

namespace OrganisationAdmin.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
