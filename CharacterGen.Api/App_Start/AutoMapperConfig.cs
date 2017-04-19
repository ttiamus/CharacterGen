namespace CharacterGen.Api
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            //One-way mapping
            //AutoMapper.Mapper.CreateMap<SourceClass, DestinationClass>();

            //Two-way mapping without extra logic
            //AutoMapper.Mapper.CreateMap<Book, BookViewModel>().ReverseMap();
            /*
            AutoMapper.Mapper.CreateMap<Book, BookViewModel>()
                .ForMember(dest => dest.Author,
                           opts => opts.MapFrom(src => src.Author.Name));
            */
        }
    }
}