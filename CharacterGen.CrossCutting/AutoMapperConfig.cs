using AutoMapper;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo.Models;

namespace CharacterGen.CrossCutting
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            //If more than one mapping use Profile instead
            Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<Language, LanguageEntity>().ReverseMap();
            });
        }
    }
}