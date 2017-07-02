namespace CharacterGen.Business.Spells.Queries.GetSpellByIdQuery
{
    public class GetSpellByIdValidator : IValidator<GetSpellByIdRequest>
    {
        public bool IsRequestValid(GetSpellByIdRequest request)
        {
            return ValidateId(request.Id);
        }

        private bool ValidateId(string id)
        {
            return !string.IsNullOrWhiteSpace(id);
        }
    }
}