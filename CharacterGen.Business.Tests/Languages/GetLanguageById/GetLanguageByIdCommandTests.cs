using System;
using CharacterGen.Business.Languages.Queries.GetLanguageByIdQuery;
using CharacterGen.Common.Exceptions;
using CharacterGen.CrossCutting;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;
using MongoDB.Driver;
using NSubstitute;
using NUnit.Framework;

namespace CharacterGen.Business.Tests.Languages.GetLanguageById
{
    [TestFixture]
    public class GetLanguageByIdCommandTests
    {
        private GetLanguageByIdRequest request;
        private IValidator<GetLanguageByIdRequest> trueValidator;
        private IValidator<GetLanguageByIdRequest> falseValidator;
        private IMongoContext context;
        private IRepository<Language> repo;

        [SetUp]
        public void Setup()
        {
            AutoMapperConfig.RegisterMappings();

            this.context = new MongoContextTestHelper();
            this.repo = new LanguageRepository(context);
            this.request = new GetLanguageByIdRequest();

            RemoveAllTestLanguages();
            InsertTestLanguage();
            
            this.trueValidator = Substitute.For<IValidator<GetLanguageByIdRequest>>();
            trueValidator.IsRequestValid(request).Returns(true);

            this.falseValidator = Substitute.For<IValidator<GetLanguageByIdRequest>>();
            falseValidator.IsRequestValid(request).Returns(false);
        }

        [Test]
        public void InvalidRequestExceptionIsThrownWhenRequestIsInvalid()
        {
            var command = new GetLanguageByIdCommand(falseValidator, repo);
            Assert.Throws<ArgumentException>(delegate { command.Execute(request); });
        }

        [Test]
        public void ResourceNotFoundExceptionIsThrownWhenLanguageCanNotBeFoundInDatabase()
        {
            RemoveAllTestLanguages();
            var command = new GetLanguageByIdCommand(trueValidator, repo);
            Assert.Throws<ResourceNotFoundException>(delegate { command.Execute(request); });
        }

        [Test]
        public void LanguageIsReturnedWhenValidatorIsTrue()
        {
            var command = new GetLanguageByIdCommand(trueValidator, repo);
            var language = command.Execute(request);
            Assert.IsFalse(language == null);
            Assert.IsTrue(language.Name.Equals("TestName"));
            Assert.IsTrue(language.Description.Equals("TestDescription"));
        }
        
        private void InsertTestLanguage()
        {
            var testEntity = new LanguageEntity()
            {
                Name = "TestName",
                Description = "TestDescription"
            };

            context.Collection<LanguageEntity>().InsertOne(testEntity);
            request.Id = testEntity.Id;
        }

        private void RemoveAllTestLanguages()
        {
            context.Collection<LanguageEntity>().DeleteMany(x => true);
        }
    }
}