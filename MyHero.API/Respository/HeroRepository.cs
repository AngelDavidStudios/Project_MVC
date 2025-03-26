using MongoDB.Driver;
using MyHero.API.Models;
using MyHero.API.Respository.Interfaces;

namespace MyHero.API.Respository;

public class HeroRepository: IHeroRepository
{
    private readonly IMongoCollection<MyHeroModel> _heroCollection;

    public HeroRepository(IMongoDatabase database)
    {
        _heroCollection = database.GetCollection<MyHeroModel>(nameof(MyHeroModel));
    }
    
    public async Task<IEnumerable<MyHeroModel>> GetAllAsync()
    {
        return await _heroCollection.Find(hero => true).ToListAsync();
    }
    
    public async Task<MyHeroModel> GetByIdAsync(string id)
    {
        return await _heroCollection.Find(hero => hero.Id == id).FirstOrDefaultAsync();
    }
    
    public async Task AddAsync(MyHeroModel hero)
    {
        await _heroCollection.InsertOneAsync(hero);
    }
    
    public async Task UpdateAsync(string id, MyHeroModel hero)
    {
        await _heroCollection.ReplaceOneAsync(hero => hero.Id == id, hero);
    }
    
    public async Task DeleteAsync(string id)
    {
        await _heroCollection.DeleteOneAsync(hero => hero.Id == id);
    }
}