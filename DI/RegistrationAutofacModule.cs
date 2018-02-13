using System.Collections.Generic;
using System.Reflection;
using Autofac;
using AutoMapper;
using fruit_api.Models;
using Microsoft.Extensions.Logging;

namespace fruit_api.DI
{
    public class RegistrationAutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<FruitService>().As<IFruitService>().InstancePerLifetimeScope();
            builder.RegisterType<FlowerService>().As<IFlowerService>().InstancePerLifetimeScope();
            
        }
    }
}