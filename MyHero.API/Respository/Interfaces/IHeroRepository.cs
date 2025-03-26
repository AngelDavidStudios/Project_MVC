using MyHero.API.Models;

namespace MyHero.API.Respository.Interfaces;

public interface IHeroRepository
{
    Task<IEnumerable<MyHeroModel>> GetAllAsync();
    Task<MyHeroModel> GetByIdAsync(string id);
    Task AddAsync(MyHeroModel hero);
    Task UpdateAsync(string id, MyHeroModel hero);
    Task DeleteAsync(string id);
}