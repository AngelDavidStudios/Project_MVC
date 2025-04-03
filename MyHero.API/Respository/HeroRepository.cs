using Amazon.DynamoDBv2.DataModel;
using MyHero.API.Models;
using MyHero.API.Respository.Interfaces;

namespace MyHero.API.Respository;

public class HeroRepository: IHeroRepository
{
    private readonly IDynamoDBContext _context;

    public HeroRepository(IDynamoDBContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<MyHeroModel>> GetAllAsync()
    {
        var conditions = new List<ScanCondition>();
        var allHeroes = await _context.ScanAsync<MyHeroModel>(conditions).GetRemainingAsync();
        return allHeroes;
    }
    
    public async Task<MyHeroModel> GetByIdAsync(string id)
    {
        return await _context.LoadAsync<MyHeroModel>(id);
    }
    
    public async Task AddAsync(MyHeroModel hero)
    {
        hero.Id = Guid.NewGuid().ToString();
        await _context.SaveAsync(hero);
    }
    
    public async Task UpdateAsync(string id, MyHeroModel hero)
    {
        var existingHero = await GetByIdAsync(id);
        if (existingHero == null)
        {
            throw new Exception("Hero not found");
        }
        
        hero.Id = id;
        await _context.SaveAsync(hero);
    }
    
    public async Task DeleteAsync(string id)
    {
        var hero = await GetByIdAsync(id);
        if (hero == null)
        {
            throw new Exception("Hero not found");
        }
        
        await _context.DeleteAsync<MyHeroModel>(id);
    }
}