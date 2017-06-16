using CharacterGen.Business.Languages.Commands.DeleteLanguageCommand;
using NUnit.Framework;

namespace CharacterGen.Business.Tests.Languages.DeleteLanguage
{
    [TestFixture]
    public class DeleteLanguageValidatorTests
    {
        [Test]
        public void DeleteLanguageValidatorShouldReturnFalseWhenIdIsNull()
        {
            IValidator<DeleteLanguageRequest> validator = new DeleteLanguageValidator();

            var request = new DeleteLanguageRequest()
            {
                Id = null
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void DeleteLanguageValidatorShouldReturnFalseWhenIdIsEmpty()
        {
            IValidator<DeleteLanguageRequest> validator = new DeleteLanguageValidator();

            var request = new DeleteLanguageRequest()
            {
                Id = ""
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void DeleteLanguageValidatorShouldReturnTrueWithValidRequest()
        {
            IValidator<DeleteLanguageRequest> validator = new DeleteLanguageValidator();

            var request = new DeleteLanguageRequest()
            {
                Id = "1"
            };

            Assert.IsTrue(validator.IsRequestValid(request));
        }
    }
}