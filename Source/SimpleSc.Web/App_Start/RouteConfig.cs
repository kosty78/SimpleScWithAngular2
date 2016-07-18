using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleSc.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            using (routes.GetWriteLock())
            {
                routes.MapRoute(
                    "sc_ignore_Bundles_Css",
                    "content/{*pathInfo}"
                    );

                routes.MapRoute(
                    "sc_ignore_Bundles_Js",
                    "bundles/{*pathInfo}"
                    );
            }
        }
    }
}
