using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "Cresearch/{action}",
                defaults: new { controller = "CResearch", action = "C01" }
            );

            routes.MapRoute(
                name: null,
                url: "V2/{controller}/{action}",
                defaults: new { controller = "MResearch", action = "M02" }
            );

            routes.MapRoute(
                name: null,
                url: "V3/{controller}/{X}/{action}",
                defaults: new { controller = "MResearch", X ="X", action = "M03"}
            );

            routes.MapRoute(
                name: null,
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MResearch", action = "M01", id = UrlParameter.Optional }
            );
        }
    }
}
