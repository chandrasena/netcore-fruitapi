using Autofac;
using fruit_api.Models;

namespace fruit_api
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<FruitContext>(opt => opt.UseInMemoryDatabase("hello")).AsSelf().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<FruitService>().As<IFruitService>().InstancePerLifetimeScope();
            builder.RegisterType<FlowerService>().As<IFlowerService>().InstancePerLifetimeScope();
        }
    }
}