using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using AutoMapper;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CharacterGen.Dal.Repositories
{
    public class LanguageRepository : Repository<Language, LanguageEntity>
    {
        public LanguageRepository(IMongoContext context) : base(context) { }
    }
}