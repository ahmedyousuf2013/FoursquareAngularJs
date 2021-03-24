using FoursquareAngularJs.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;

namespace FoursquareAngularJs
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            //builder.EntitySet<Countries>("Countries");
            //config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());


            // Web API routes
            config.MapHttpAttributeRoutes();
           var cors = new EnableCorsAttribute("*", "*", "*");

            config.AddODataQueryFilter();

            config.EnableCors(cors);
            config.Formatters.JsonFormatter.SupportedMediaTypes
            .Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            
        }
    }
}
