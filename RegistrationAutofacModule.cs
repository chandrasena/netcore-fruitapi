using System.Collections.Generic;
using System.Reflection;
using Autofac;
using AutoMapper;
using fruit_api.Models;

namespace fruit_api
{
    public class RegistrationAutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            // builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly.GetEntryAssembly())
            // .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract && t.IsPublic)
            // .As<Profile>();

            // builder.Register(c => new MapperConfiguration(cfg => {
            //     var xxx = c.Resolve<IEnumerable<Profile>>();
            // foreach (var profile in c.Resolve<IEnumerable<Profile>>()) {
            //     cfg.AddProfile(profile);
            // }
            // })).AsSelf().SingleInstance();
            // builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();
            //services.AddTransient<IMapper>();
            //builder.RegisterType<FruitContext>(opt => opt.UseInMemoryDatabase("hello")).AsSelf().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<FruitService>().As<IFruitService>().InstancePerLifetimeScope();
            builder.RegisterType<FlowerService>().As<IFlowerService>().InstancePerLifetimeScope();
        }
    }
}