using System.Web.Mvc;
using MVC.DI.Autofac.Data;

namespace MVC.DI.Autofac.Web.Filters
{
    public class LocalizationFilter : ActionFilterAttribute
    {
        public IAppContext AppContext { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            AppContext.Execute();
        }
    }
}