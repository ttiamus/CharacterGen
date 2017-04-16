using CharacterGen.DependencyResolver;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CharacterGen.Common.Json;
using Newtonsoft.Json;

namespace CharacterGen.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var container = Bootstrapper.GetContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings = 
                new JsonSerializerSettings() { Converters = new List<JsonConverter> { new ObjectIdConverter() } };
            
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
