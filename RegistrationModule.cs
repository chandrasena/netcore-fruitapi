using Autofac;
using fruit_api.Models;

namespace fruit_api
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<FruitService>().As<IFruitService>().InstancePerLifetimeScope();
        }
    }
}