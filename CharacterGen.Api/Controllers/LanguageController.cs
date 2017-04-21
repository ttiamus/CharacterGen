using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CharacterGen.Business.Languages.Commands.CreateLanguageCommand;
using CharacterGen.Business.Languages.Commands.DeleteLanguageCommand;
using CharacterGen.Business.Languages.Commands.UpdateLanguageCommand;
using CharacterGen.Business.Languages.Queries.GetLanguageByIdQuery;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Api.Controllers
{
    public class LanguageController : ApiController
    {
        private readonly CreateLanguageCommand createLanguageCommand;
        private readonly UpdateLanguageCommand updateLanguageCommand;
        private readonly DeleteLanguageCommand deleteLanguageCommand;

        public LanguageController(
            CreateLanguageCommand createLanguageCommand,
            UpdateLanguageCommand updateLanguageCommand,
            DeleteLanguageCommand deleteLanguageCommand)
        {
            this.createLanguageCommand = createLanguageCommand;
            this.updateLanguageCommand = updateLanguageCommand;
            this.deleteLanguageCommand = deleteLanguageCommand;
        }

        // GET: api/Language
        [HttpGet]
        [Route("language")]
        public IEnumerable<Language> Get()
        {
            return new List<Language>();
        }

        // GET: api/Language/5
        [HttpGet]
        [Route("language/{id}")]
        public Language Get(GetLanguageByIdRequest request)
        {
            return new Language();
        }

        // POST: api/Language
        [HttpPost]
        [Route("language")]
        public void Post(CreateLanguageRequest request)
        {
            createLanguageCommand.Execute(request);
        }

        // PUT: api/Language/5
        [HttpPut]
        [Route("language")]
        public void Put(UpdateLanguageRequest request)
        {
            updateLanguageCommand.Execute(request);
        }

        // DELETE: api/Language/5
        [HttpDelete]
        [Route("language")]
        public void Delete(DeleteLanguageRequest request)
        {
            deleteLanguageCommand.Execute(request);
        }
    }
}
