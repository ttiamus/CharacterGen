using System.Collections.Generic;
using System.Linq;
using CharacterGen.Business.Languages.Queries.GetLanguagesQuery;
using CharacterGen.CrossCutting;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;
using MongoDB.Driver;
using NUnit.Framework;

namespace CharacterGen.Business.Tests.Languages.GetLanguages
{
    public class GetLanguagesCommandTests
    {
        private GetLanguagesRequest request;
        private IMongoContext context;
        private IRepository<Language> repo;

        [SetUp]
        public void Setup()
        {
            AutoMapperConfig.RegisterMappings();

            this.context = new MongoContextTestHelper();
            this.repo = new LanguageRepository(context);
            this.request = new GetLanguagesRequest();
        }

        [Test]
        public void AllLanguagesInDatabaseAreReturned()
        {
            RemoveAllTestLanguages();
            InsertTestLanguages();

            var command = new GetLanguagesQuery(repo);
            var languages = command.Execute(request).ToList();
            
            Assert.IsTrue(languages.Any());
            Assert.IsTrue(languages.Count() == 3);
            Assert.IsTrue(languages.Any(x => x.Name.Equals("Name1")));
            Assert.IsTrue(languages.Any(x => x.Name.Equals("Name2")));
            Assert.IsTrue(languages.Any(x => x.Name.Equals("Name3")));
        }

        public void WhenThereAreNoLanguagesAnEmptyListShouldBeReturned()
        {
            RemoveAllTestLanguages();
            var command = new GetLanguagesQuery(repo);
            var languages = command.Execute(request).ToList();
            Assert.IsFalse(languages == null);
            Assert.IsFalse(languages.Any());
        }

        private void InsertTestLanguages()
        {
            var testEntity1 = new LanguageEntity()
            {
                Name = "Name1",
                Description = "Name1"
            };

            var testEntity2 = new LanguageEntity()
            {
                Name = "Name2",
                Description = "Name2"
            };

            var testEntity3 = new LanguageEntity()
            {
                Name = "Name3",
                Description = "Name3"
            };

            var entities = new List<LanguageEntity>()
            {
                testEntity1, testEntity2, testEntity3
            };

            context.Collection<LanguageEntity>().InsertMany(entities);
        }

        private void RemoveAllTestLanguages()
        {
            context.Collection<LanguageEntity>().DeleteMany(x => true);
        }
    }
}