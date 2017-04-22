using CharacterGen.Common.Json;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace CharacterGen.Business.Languages.Queries.GetLanguageByIdQuery
{
    public class GetLanguageByIdRequest
    {
        public string Id { get; set; }
    }
}