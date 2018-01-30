using Autofac;

namespace MVC.DI.Autofac.Data.Configuration
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppContext>().As<IAppContext>().InstancePerRequest();
        }
    }
}
