using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OktaNetCoreMvcMongoExample.Models
{
    public class Submission
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string UserId { get; set; }
        
        public string UserName { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
