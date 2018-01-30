using System.Threading;

namespace MVC.DI.Autofac.Data
{
    public class AppContext : IAppContext
    {
        public void Execute()
        {
            Thread.Sleep(5);                
        }
    }
}
