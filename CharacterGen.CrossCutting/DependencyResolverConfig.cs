
using CharacterGen.Business;
using CharacterGen.Common.Http;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace CharacterGen.CrossCutting
{
    public static class DependencyResolverConfig
    {
        public static Container GetContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            
            container.Register<IHttpHelper, HttpHelper>(Lifestyle.Scoped);
            //container.RegisterConditional(typeof(IRepository<>), typeof(Repository<>), c => !c.Handled);

            container.Register<IMongoContext, MongoContext>(Lifestyle.Scoped);

            //Regiesters IValidator to be able to resolve to any concrete class that implements it
            container.Register(typeof(IValidator<>), new[] { typeof(IValidator<>).Assembly });

            container.Register<ILanguage, Language>(Lifestyle.Scoped);
            container.Register<IRepository<Language>, LanguageRepository>(Lifestyle.Scoped);
            
            return container;
        }
    }
    
}