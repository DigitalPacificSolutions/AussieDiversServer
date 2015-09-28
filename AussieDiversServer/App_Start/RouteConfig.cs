using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AussieDiversServer
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Api",
                url: "api/{controller}/{action}/{id}",
                defaults: new { id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home",
                url: "{*path}",
                defaults: new { controller = "Home", action = "Index" }
            );

            

            
        }
    }
}
