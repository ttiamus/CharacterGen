namespace CharacterGen.Business.Languages.Commands.CreateLanguageCommand
{
    public class CreateLanguageRequest : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}