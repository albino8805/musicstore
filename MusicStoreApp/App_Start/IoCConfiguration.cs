using Autofac;
using Autofac.Integration.Mvc;
using MusicStoreApp.Manager;
using MusicStoreApp.Manager.IManager;
using MusicStoreApp.Models;
using MusicStoreApp.Repository;
using MusicStoreApp.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreApp.App_Start
{
    public class IoCConfiguration
    {
        public static void RegisterControllers(ContainerBuilder builder)
        {
            builder.RegisterControllers
            (Assembly.GetExecutingAssembly());
        }

        public static void RegisterRepos(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryRepository>()
                .As<ICategoryRepository>().InstancePerRequest();

            builder.RegisterType<CategoryManager>()
                .As<ICategoryManager>().InstancePerRequest();            
        }

        public static void RegisterClass(ContainerBuilder builder)
        {
            builder.Register(z => new MusicStoreEntities()).
                            InstancePerRequest();
        }
        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();

            RegisterControllers(builder);
            RegisterRepos(builder);
            RegisterClass(builder);

            IContainer contenedor = builder.Build();

            DependencyResolver.SetResolver
                (new AutofacDependencyResolver(contenedor));
        }
    }
}