using System;
using System.Linq;
using CharacterGen.Business.Languages.Commands.CreateLanguageCommand;
using CharacterGen.CrossCutting;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;
using MongoDB.Driver;
using NSubstitute;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;


namespace CharacterGen.Business.Tests.Languages.CreateLanguage
{
    [TestFixture]
    public class CreateLanguageCommandTests
    {
        private CreateLanguageRequest request;
        private IValidator<CreateLanguageRequest> trueValidator;
        private IValidator<CreateLanguageRequest> falseValidator;
        private IMongoContext context;
        private IRepository<Language> repo;
        //private int CurrentLanguageCount;

        [SetUp]
        public void Setup()
        {
            AutoMapperConfig.RegisterMappings();

            this.request = new CreateLanguageRequest()
            {
                Name = "Name",
                Description = "Description"
            };

            this.trueValidator = Substitute.For<IValidator<CreateLanguageRequest>>();
            trueValidator.IsRequestValid(request).Returns(true);

            this.falseValidator = Substitute.For<IValidator<CreateLanguageRequest>>();
            falseValidator.IsRequestValid(request).Returns(false);

            this.context = new MongoContextTestHelper();
            this.repo = new LanguageRepository(context);

            //this.CurrentLanguageCount = context.Collection<Language>().Find(x => true).ToList().Count;
        }
        
        [Test]
        public void LanguageIsCreatedWithTrueValidation()
        {
            var command = new CreateLanguageCommand(trueValidator, repo);

            var currentCount = context.Collection<LanguageEntity>().AsQueryable().ToList().Count;
            
            command.Execute(request);

            var countAfterCreation = context.Collection<LanguageEntity>().AsQueryable().ToList().Count;

            Assert.IsTrue(countAfterCreation == currentCount + 1);
        }

        [Test]
        public void LanguageIsNotCreatedWithFalseValidation()
        {
            var command = new CreateLanguageCommand(falseValidator, repo);

            var currentCount = context.Collection<LanguageEntity>().AsQueryable().ToList().Count;

            Assert.Throws<NotImplementedException>(() => command.Execute(request));

            var countAfterCreation = context.Collection<LanguageEntity>().AsQueryable().ToList().Count;

            Assert.IsTrue(countAfterCreation == currentCount);
        }
    }
}
