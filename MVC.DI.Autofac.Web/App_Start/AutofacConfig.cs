using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MVC.DI.Autofac.Data.Configuration;
using MVC.DI.Autofac.Web.App_Start.Modules;

namespace MVC.DI.Autofac.Web.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            builder.RegisterFilterProvider();
            
            builder.RegisterSource(new ViewRegistrationSource());

            builder.RegisterModule<DataModule>();

            builder.RegisterModule<FiltersModule>();

            var container = builder.Build();
            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}