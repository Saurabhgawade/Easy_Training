﻿using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB2.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }
        
        [BsonElement("password")]
        public string Password { get; set; }
    }
}
