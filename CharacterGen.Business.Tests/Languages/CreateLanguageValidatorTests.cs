using CharacterGen.Business.Languages.Commands.CreateLanguageCommand;
using NUnit.Framework;

namespace CharacterGen.Business.Tests.Languages
{
    [TestFixture]
    public class CreateLanguageValidatorTests
    {
        [Test]
        public void CreateLanguageValidatorReturnsFalseWhenNameIsEmpty()
        {
            IValidator<CreateLanguageRequest> validator = new CreateLanguageValidator();

            var request = new CreateLanguageRequest()
            {
                Name = "",
                Description = "Description"
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void CreateLanguageValidatorReturnsFalseWhenNameIsNull()
        {
            IValidator<CreateLanguageRequest> validator = new CreateLanguageValidator();

            var request = new CreateLanguageRequest()
            {
                Name = null,
                Description = "Description"
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void CreateLanguageValidatorReturnsFalseWhenDescriptionIsEmpty()
        {
            IValidator<CreateLanguageRequest> validator = new CreateLanguageValidator();

            var request = new CreateLanguageRequest()
            {
                Name = "Name",
                Description = ""
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void CreateLanguageValidatorReturnsFalseWhenDescriptionIsNull()
        {
            IValidator<CreateLanguageRequest> validator = new CreateLanguageValidator();

            var request = new CreateLanguageRequest()
            {
                Name = "Name",
                Description = null
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void CreateLanguageValidatorReturnsTrueForValidRequest()
        {
            IValidator<CreateLanguageRequest> validator = new CreateLanguageValidator();

            var request = new CreateLanguageRequest()
            {
                Name = "Name",
                Description = "Description"
            };

            Assert.IsTrue(validator.IsRequestValid(request));
        }
    }
}