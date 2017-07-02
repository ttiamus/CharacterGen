namespace CharacterGen.Business.Spells.Queries.GetSpellByIdQuery
{
    public class GetSpellByIdRequest : IRequest
    {
        public string Id { get; set; }
    }
}