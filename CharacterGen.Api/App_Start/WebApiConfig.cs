using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace CharacterGen.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //config.Services.Insert(typeof(System.Web.Http.ModelBinding.ModelBinderProvider), 
            //      0, // Insert at front to ensure other catch-all binders don’t claim it first
            //      new BsonObjectModelSerializationProvider()); 


            config.BindParameter(typeof(ObjectId), new ObjectIdBinder());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
