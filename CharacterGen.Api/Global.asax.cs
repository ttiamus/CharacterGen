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
using SimpleInjector;

namespace CharacterGen.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var config = GlobalConfiguration.Configuration;

            var container = DependencyResolverConfig.GetContainer();
            container.RegisterWebApiControllers(config);
            container.Verify();     //Check that everything is registered correctly
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            AutoMapperConfig.RegisterMappings();

            config.Formatters.JsonFormatter.SerializerSettings = 
                new JsonSerializerSettings() { Converters = new List<JsonConverter> { new ObjectIdConverter() } };
            
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
