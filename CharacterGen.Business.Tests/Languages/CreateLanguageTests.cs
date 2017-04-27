using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using CharacterGen.Business.Languages.Commands.CreateLanguageCommand;
using CharacterGen.Dal.Repositories;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
using MongoDB.Driver;
using NUnit.Framework;


namespace CharacterGen.Business.Tests.Languages
{
    [TestFixture]
    public class CreateLanguageTests
    {
        private IMongoContext context;
        private CreateLanguageValidator validator;
        private IRepository<Language> repo;

        [SetUp]
        public void Setup()
        {
            this.context = new MongoContextTestHelper();
            this.validator = new CreateLanguageValidator();
            this.repo = new LanguageRepository(context);
        }

        [Test]
        public void ValidationFailsWithEmptyName()
        {
            var request = new CreateLanguageRequest()
            {
                Name = "",
                Description = "DescriptionTest"
            };

            Assert.False(validator.IsRequestValid(request));
        }

        [Test]
        public void ValidationFailsWithNullName()
        {
            var request = new CreateLanguageRequest()
            {
                Name = null,
                Description = "DescriptionTest"
            };

            Assert.False(validator.IsRequestValid(request));
        }

        [Test]
        public void ValidationFailsWithEmptyDescription()
        {
            var request = new CreateLanguageRequest()
            {
                Name = "NameTest",
                Description = ""
            };

            Assert.False(validator.IsRequestValid(request));
        }

        [Test]
        public void ValidationFailsWithNullDescription()
        {
            var request = new CreateLanguageRequest()
            {
                Name = "NameTest",
                Description = null
            };

            Assert.False(validator.IsRequestValid(request));
        }

        [Test]
        public void LanguageIsCreatedWithValidRequest()
        {
            var command = new CreateLanguageCommand(validator, repo);

            //var currentCount = context.Collection<Language>().Find(x => true).ToList().Count;
            var currentCount = 1;
            var request = new CreateLanguageRequest()
            {
                Name = $"Name{currentCount}",
                Description = $"Some Description{currentCount}"
            };

            command.Execute(request);

            var countAfterCreation = context.Collection<Language>().Find(x => true).ToList().Count;

            Assert.IsTrue(countAfterCreation == context.Collection<Language>().AsQueryable().Count() + 1);
        }
    }
}
