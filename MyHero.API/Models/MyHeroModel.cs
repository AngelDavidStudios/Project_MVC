using MongoDB.Bson.Serialization.Attributes;

namespace MyHero.API.Models;

public class MyHeroModel
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }
    public string name { get; set; }
    public string alias { get; set; }
    public string power { get; set; }
    public int level { get; set; }
    public bool isAlive { get; set; }
    public string description { get; set; }
}