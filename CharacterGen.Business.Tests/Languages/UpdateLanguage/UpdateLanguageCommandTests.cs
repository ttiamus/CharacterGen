using CharacterGen.Business.Languages.Commands.UpdateLanguageCommand;
using CharacterGen.CrossCutting;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;
using MongoDB.Driver;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CharacterGen.Business.Tests.Languages.UpdateLanguage
{
    [TestFixture]
    public class UpdateLanguageCommandTests
    {
        private UpdateLanguageRequest request;
        private IValidator<UpdateLanguageRequest> trueValidator;
        private IValidator<UpdateLanguageRequest> falseValidator;
        private IMongoContext context;
        private IRepository<Language> repo;

        [SetUp]
        public void Setup()
        {
            AutoMapperConfig.RegisterMappings();

            this.context = new MongoContextTestHelper();
            this.repo = new LanguageRepository(context);

            RemoveAllTestLanguages();
            InsertTestLanguage();
            var language = context.Collection<LanguageEntity>()?.Find(x => true).FirstOrDefault();

            this.request = new UpdateLanguageRequest()
            {
                Id = language.Id,
                Name = "NameAfterTest",
                Description = "DescriptionAfterTest"
            };

            this.trueValidator = Substitute.For<IValidator<UpdateLanguageRequest>>();
            trueValidator.IsRequestValid(request).Returns(true);

            this.falseValidator = Substitute.For<IValidator<UpdateLanguageRequest>>();
            falseValidator.IsRequestValid(request).Returns(false);
        }

        [Test]
        public void LanguageIsNotUpdatedWhenValidatorIsFalse()
        {
            var command = new UpdateLanguageCommand(falseValidator, repo);

            var currentLanguage = context.Collection<LanguageEntity>().Find(x => x.Id.Equals(request.Id)).First();
            command.Execute(request);
            var languageAfterExecution = context.Collection<LanguageEntity>().Find(x => x.Id.Equals(request.Id)).First();

            Assert.IsTrue(currentLanguage.Name.Equals(languageAfterExecution.Name));
            Assert.IsTrue(currentLanguage.Description.Equals(languageAfterExecution.Description));

            Assert.IsFalse(request.Name.Equals(languageAfterExecution.Name));
            Assert.IsFalse(request.Description.Equals(languageAfterExecution.Description));
        }

        [Test]
        public void LanguageIsUpdatedWhenValidatorIsTrue()
        {
            var command = new UpdateLanguageCommand(trueValidator, repo);
            command.Execute(request);
            var updatedLanguage = context.Collection<LanguageEntity>().Find(x => x.Id.Equals(request.Id)).First();

            Assert.IsTrue(request.Name.Equals(updatedLanguage.Name));
            Assert.IsTrue(request.Description.Equals(updatedLanguage.Description));
        }

        private void InsertTestLanguage()
        {
            var testEntity = new LanguageEntity()
            {
                Name = "NameBeforeTest",
                Description = "Description"
            };
            context.Collection<LanguageEntity>().InsertOne(testEntity);
        }

        private void RemoveAllTestLanguages()
        {
            context.Collection<LanguageEntity>().DeleteMany(x => true);
        }
    }
}