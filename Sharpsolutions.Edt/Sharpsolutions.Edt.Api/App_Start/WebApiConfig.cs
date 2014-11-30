using Castle.Windsor;
using Newtonsoft.Json.Serialization;
using Sharpsolutions.Edt.System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace Sharpsolutions.Edt.Api {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config, IWindsorContainer container) {
            // Web API configuration and services
            config.Services.Replace(typeof(IHttpControllerActivator),
                new WindsorControllerActivator(container));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );



            JsonMediaTypeFormatter jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
