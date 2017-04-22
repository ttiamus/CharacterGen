using MongoDB.Bson;

namespace CharacterGen.Domain
{
    //This is needed so the generic repository can access the Id property of the Generic roots
    public interface IEntity
    {
        string Id { get; }
    }
}