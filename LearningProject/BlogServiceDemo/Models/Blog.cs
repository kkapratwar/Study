using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlogServiceDemo.Models
{
    public class Blog
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
