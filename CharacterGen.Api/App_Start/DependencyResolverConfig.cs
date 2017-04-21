using System.CodeDom;
using CharacterGen.Common.Http;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
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
            container.Register(typeof(IRepository<>), typeof(Repository<>), Lifestyle.Scoped);

            container.Register<MongoContext>(Lifestyle.Scoped);

            container.Register<ILanguage, Language>(Lifestyle.Scoped);
            
            return container;
        }
    }
    
}