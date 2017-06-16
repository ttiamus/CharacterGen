using CharacterGen.Business.Languages.Commands.UpdateLanguageCommand;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CharacterGen.Business.Tests.Languages.UpdateLanguage
{
    [TestFixture]
    public class UpdateLanguageValidatorTests
    {
        [Test]
        public void UpdateLanguageValidatorShouldReturnFalseWhenIdIsNull()
        {
            IValidator<UpdateLanguageRequest> validator = new UpdateLanguageValidator();

            var request = new UpdateLanguageRequest()
            {
                Id = null,
                Name = "Name",
                Description = "Description"
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void UpdateLanguageValidatorShouldReturnFalseWhenIdIsEmpty()
        {
            IValidator<UpdateLanguageRequest> validator = new UpdateLanguageValidator();
            var request = new UpdateLanguageRequest()
            {
                Id = "",
                Name = "Name",
                Description = "Description"
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void UpdateLanguageValidatorShouldReturnFalseWhenNameIsNull()
        {
            IValidator<UpdateLanguageRequest> validator = new UpdateLanguageValidator();

            var request = new UpdateLanguageRequest()
            {
                Id = "1",
                Name = null,
                Description = "Description"
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void UpdateLanguageValidatorShouldReturnFalseWhenNameIsEmpty()
        {
            IValidator<UpdateLanguageRequest> validator = new UpdateLanguageValidator();
            var request = new UpdateLanguageRequest()
            {
                Id = "1",
                Name = "",
                Description = "Description"
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void UpdateLanguageValidatorShouldReturnFalseWhenDescriptionIsNull()
        {
            IValidator<UpdateLanguageRequest> validator = new UpdateLanguageValidator();

            var request = new UpdateLanguageRequest()
            {
                Id = "1",
                Name = "Name",
                Description = null
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void UpdateLanguageValidatorShouldReturnFalseWhenDescriptionIsEmpty()
        {
            IValidator<UpdateLanguageRequest> validator = new UpdateLanguageValidator();
            var request = new UpdateLanguageRequest()
            {
                Id = "1",
                Name = "Name",
                Description = ""
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void DeleteLanguageValidatorShouldReturnTrueWithValidRequest()
        {
            IValidator<UpdateLanguageRequest> validator = new UpdateLanguageValidator();

            var request = new UpdateLanguageRequest()
            {

                Id = "1",
                Name = "Name",
                Description = "Description"
            };

            Assert.IsTrue(validator.IsRequestValid(request));
        }
    }
}