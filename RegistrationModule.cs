using Autofac;

namespace fruit_api
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FruitService>().As<IFruitService>();
        }
    }
}