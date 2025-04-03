
using Amazon.DynamoDBv2.DataModel;

namespace MyHero.API.Models;

[DynamoDBTable("MyHero")]
public class MyHeroModel
{
    [DynamoDBHashKey("id")]
    public string? Id { get; set; }
    
    [DynamoDBProperty]
    public string name { get; set; }
    
    [DynamoDBProperty]
    public string alias { get; set; }
    
    [DynamoDBProperty]
    public string power { get; set; }
    
    [DynamoDBProperty]
    public int level { get; set; }
    
    [DynamoDBProperty]
    public bool isAlive { get; set; }
    
    [DynamoDBProperty]
    public string description { get; set; }
}