namespace CharacterGen.Business
{
    public interface IValidator<in TRequest> where TRequest : IRequest
    {
        bool IsRequestValid(TRequest request);
    }
}