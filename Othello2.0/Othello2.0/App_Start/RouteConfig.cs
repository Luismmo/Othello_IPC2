﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Othello2._0
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "HomeOthello",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "HomeOthello", id = UrlParameter.Optional }
            );
        }
    }
}