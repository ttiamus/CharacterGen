using CharacterGen.Business.Languages.Commands.DeleteLanguageCommand;
using CharacterGen.CrossCutting;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;
using MongoDB.Driver;
using NSubstitute;
using NUnit.Framework;

namespace CharacterGen.Business.Tests.Languages
{
    [TestFixture]
    public class DeleteLanguageCommandTests
    {
        private DeleteLanguageRequest request;
        private IValidator<DeleteLanguageRequest> trueValidator;
        private IValidator<DeleteLanguageRequest> falseValidator;
        private IMongoContext context;
        private IRepository<Language> repo;

        [SetUp]
        public void Setup()
        {
            AutoMapperConfig.RegisterMappings();

            this.context = new MongoContextTestHelper();
            this.repo = new LanguageRepository(context);

            var language = context.Collection<Language>()?.Find(x => true).FirstOrDefault();
            if(language == null)
                Assert.Fail("There was not a language in the test database to delete");

            this.request = new DeleteLanguageRequest()
            {
                Id = language.Id
            };

            this.trueValidator = Substitute.For<IValidator<DeleteLanguageRequest>>();
            trueValidator.IsRequestValid(request).Returns(true);

            this.falseValidator = Substitute.For<IValidator<DeleteLanguageRequest>>();
            falseValidator.IsRequestValid(request).Returns(false);
        }

        [Test]
        public void LanguageIsNotDeletedWhenValidatorIsFalse()
        {
            var command = new DeleteLanguageCommand(falseValidator, repo);

            var currentCount = context.Collection<LanguageEntity>().AsQueryable().ToList().Count;

            command.Execute(request);

            var countAfterCreation = context.Collection<LanguageEntity>().AsQueryable().ToList().Count;

            Assert.IsTrue(countAfterCreation == currentCount);
        }

        [Test]
        public void LanguageIsDeletedWhenValidatorIsTrue()
        {
            var command = new DeleteLanguageCommand(trueValidator, repo);

            var currentCount = context.Collection<LanguageEntity>().AsQueryable().ToList().Count;

            command.Execute(request);

            var countAfterCreation = context.Collection<LanguageEntity>().AsQueryable().ToList().Count;

            Assert.IsTrue(countAfterCreation == currentCount - 1);
        }
    }
}