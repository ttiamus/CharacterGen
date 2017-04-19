using CharacterGen.Common.Http;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace CharacterGen.Api
{
    public static class DependencyResolverConfig
    {
        public static Container GetContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IHttpHelper, HttpHelper>(Lifestyle.Scoped);
            return container;
        }
    }
    
}