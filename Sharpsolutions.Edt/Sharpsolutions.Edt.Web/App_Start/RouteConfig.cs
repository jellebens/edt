using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;

namespace Sharpsolutions.Edt.Web {
    public static class RouteConfig {
        internal static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                            name: "CatchAll",
                            url: "{*url}",
                            defaults: new { controller = "Home", action = "Index" });
        }
    }
}