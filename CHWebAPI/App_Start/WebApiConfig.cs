using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CHWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{category}",
            //    defaults: new { category = "all" }
            //);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "ControllersApi",
                routeTemplate: "api/{controller}/{action}"
            );
            
        }
    }
}
