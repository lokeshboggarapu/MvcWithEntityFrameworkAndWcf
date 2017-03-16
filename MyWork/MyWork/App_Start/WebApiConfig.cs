﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiContrib.Formatting.Jsonp;

namespace MyWork
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        //    var jsonpFormatter = new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
        //    config.Formatters.Insert(0, jsonpFormatter);
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors();
        }
    }
}
