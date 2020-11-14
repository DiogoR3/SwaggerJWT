using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SwaggerJWT.Models
{
    public class Car
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
    }
}
