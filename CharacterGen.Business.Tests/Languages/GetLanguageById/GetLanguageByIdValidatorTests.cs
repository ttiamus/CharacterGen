using CharacterGen.Business.Languages.Queries.GetLanguageByIdQuery;
using NUnit.Framework;

namespace CharacterGen.Business.Tests.Languages.GetLanguageById
{
    [TestFixture]
    public class GetLanguageByIdValidatorTests
    {
        [Test]
        public void GetLanguageByIdValidatorShouldReturnFalseWhenIdIsNull()
        {
            IValidator<GetLanguageByIdRequest> validator = new GetLanguageByIdValidator();

            var request = new GetLanguageByIdRequest()
            {
                Id = null
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void GetLanguageByIdLanguageValidatorShouldReturnFalseWhenIdIsEmpty()
        {
            IValidator<GetLanguageByIdRequest> validator = new GetLanguageByIdValidator();

            var request = new GetLanguageByIdRequest()
            {
                Id = ""
            };

            Assert.IsFalse(validator.IsRequestValid(request));
        }

        [Test]
        public void GetLanguageByIdLanguageValidatorShouldReturnTrueWithValidRequest()
        {
            IValidator<GetLanguageByIdRequest> validator = new GetLanguageByIdValidator();

            var request = new GetLanguageByIdRequest()
            {
                Id = "1"
            };

            Assert.IsTrue(validator.IsRequestValid(request));
        }
    }
}