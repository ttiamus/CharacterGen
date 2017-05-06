
using CharacterGen.Business;
using CharacterGen.Common.Http;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Background;
using CharacterGen.Domain.Class;
using CharacterGen.Domain.Equipment.AdventuringGear;
using CharacterGen.Domain.Equipment.Armor;
using CharacterGen.Domain.Equipment.Tool;
using CharacterGen.Domain.Equipment.Weapon;
using CharacterGen.Domain.Equipment.WonderousItem;
using CharacterGen.Domain.Feat;
using CharacterGen.Domain.Languages;
using CharacterGen.Domain.Race;
using CharacterGen.Domain.Spell;
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

            container.Register<IBackground, Background>(Lifestyle.Scoped);
            container.Register<IRepository<Background>, BackgroundRepository>(Lifestyle.Scoped);

            container.Register<IClass, Class>(Lifestyle.Scoped);
            container.Register<IRepository<Class>, ClassRepository>(Lifestyle.Scoped);

            container.Register<IFeat, Feat>(Lifestyle.Scoped);
            container.Register<IRepository<Feat>, FeatRepository>(Lifestyle.Scoped);

            container.Register<ILanguage, Language>(Lifestyle.Scoped);
            container.Register<IRepository<Language>, LanguageRepository>(Lifestyle.Scoped);

            container.Register<IRace, Race>(Lifestyle.Scoped);
            container.Register<IRepository<Race>, RaceRepository>(Lifestyle.Scoped);

            container.Register<ISpell, Spell>(Lifestyle.Scoped);
            container.Register<IRepository<Spell>, SpellRepository>(Lifestyle.Scoped);

            //Equipment
            container.Register<IAdventuringGear, AdventuringGear>(Lifestyle.Scoped);
            container.Register<IRepository<AdventuringGear>, AdventuringGearRepository>(Lifestyle.Scoped);

            container.Register<IArmor, Armor>(Lifestyle.Scoped);
            container.Register<IRepository<Armor>, ArmorRepository>(Lifestyle.Scoped);

            container.Register<ITool, Tool>(Lifestyle.Scoped);
            container.Register<IRepository<Tool>, ToolRepository>(Lifestyle.Scoped);

            container.Register<IWeapon, Weapon>(Lifestyle.Scoped);
            container.Register<IRepository<Weapon>, WeaponRepository>(Lifestyle.Scoped);

            container.Register<IWonderousItem, WonderousItem>(Lifestyle.Scoped);
            container.Register<IRepository<WonderousItem>, WonderousItemRepository>(Lifestyle.Scoped);

            return container;
        }
    }
    
}