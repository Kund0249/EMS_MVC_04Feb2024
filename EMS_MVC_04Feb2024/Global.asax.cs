using EMS_MVC_04Feb2024.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace EMS_MVC_04Feb2024
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //GlobalFilters.Filters.Add(new HandleErrorAttribute());
            FilterConfig.RegisterFilters();
            BundlingConfig.RegisterBundle(BundleTable.Bundles);
        }
    }
}
