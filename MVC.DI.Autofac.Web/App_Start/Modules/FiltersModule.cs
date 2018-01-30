using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MVC.DI.Autofac.Data;
using MVC.DI.Autofac.Web.Filters;

namespace MVC.DI.Autofac.Web.App_Start.Modules
{
    public class FiltersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new LocalizationFilter {AppContext = c.Resolve<IAppContext>()})
                .AsActionFilterFor<Controller>()
                .InstancePerRequest();

            builder.RegisterFilterProvider();
        }
    }
}