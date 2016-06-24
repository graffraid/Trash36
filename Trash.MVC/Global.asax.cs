namespace Trash.MVC
{
    using System.Web.Mvc;
    using System.Web.Routing;

    using Trash.MVC.App_Start;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            AutoMapperConfig.Configure();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
