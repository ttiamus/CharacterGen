﻿using MongoDB.Bson.Serialization.Conventions;

namespace CharacterGen.Domain.Class
{
    public class Class : IClass
    {
        public string Id { get; set; }
    }
}