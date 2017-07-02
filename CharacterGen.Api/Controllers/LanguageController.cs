using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Http;
using CharacterGen.Business.Languages.Commands.CreateLanguageCommand;
using CharacterGen.Business.Languages.Commands.DeleteLanguageCommand;
using CharacterGen.Business.Languages.Commands.UpdateLanguageCommand;
using CharacterGen.Business.Languages.Queries.GetLanguageByIdQuery;
using CharacterGen.Business.Languages.Queries.GetLanguagesQuery;
using CharacterGen.Domain.Languages;
using MongoDB.Bson;

namespace CharacterGen.Api.Controllers
{
    public class LanguageController : ApiController
    {
        private readonly GetLanguagesQuery getLanguagesCommand;
        private readonly GetLanguageByIdQuery getLanguageByIdCommand;
        private readonly CreateLanguageCommand createLanguageCommand;
        private readonly UpdateLanguageCommand updateLanguageCommand;
        private readonly DeleteLanguageCommand deleteLanguageCommand;

        public LanguageController(
            GetLanguagesQuery getLanguagesCommand,
            GetLanguageByIdQuery getLanguageByIdCommand,
            CreateLanguageCommand createLanguageCommand,
            UpdateLanguageCommand updateLanguageCommand,
            DeleteLanguageCommand deleteLanguageCommand)
        {
            this.getLanguagesCommand = getLanguagesCommand;
            this.getLanguageByIdCommand = getLanguageByIdCommand;
            this.createLanguageCommand = createLanguageCommand;
            this.updateLanguageCommand = updateLanguageCommand;
            this.deleteLanguageCommand = deleteLanguageCommand;
        }

        [HttpGet]
        [Route("language")]
        public IEnumerable<Language> Get(GetLanguagesRequest request)
        {
            throw new ArgumentException("TestMEssage");
            return getLanguagesCommand.Execute(request);
        }

        [HttpGet]
        [Route("language/{id}")]
        public Language Get([FromUri] GetLanguageByIdRequest request)
        {
            //TODO: Handle not found
            return getLanguageByIdCommand.Execute(request);
        }

        //TODO: Find a way to make ObjectId bind within request body
        [HttpPost]
        [Route("language/create")]
        public void Post(CreateLanguageRequest request)
        {
            createLanguageCommand.Execute(request);
        }

        [HttpPut]
        [Route("language/update")]
        public void Put([FromBody] UpdateLanguageRequest request)
        {
            updateLanguageCommand.Execute(request);
        }

        [HttpDelete]
        [Route("language/delete")]
        public void Delete([FromBody] DeleteLanguageRequest request)
        {
            deleteLanguageCommand.Execute(request);
        }
    }
}
