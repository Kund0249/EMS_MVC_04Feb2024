using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EMS_MVC_04Feb2024
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

         //   routes.MapRoute(
         //    name: "Employee List",
         //    url: "Employee",
         //    defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
         //);
         //   routes.MapRoute(
         //      name: "New Employee",
         //      url: "Employee/Add",
         //      defaults: new { controller = "Employee", action = "Create", id = UrlParameter.Optional }
         //  );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Department", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
