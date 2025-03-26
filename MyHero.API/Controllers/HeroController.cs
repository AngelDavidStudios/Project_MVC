using Microsoft.AspNetCore.Mvc;
using MyHero.API.Models;
using MyHero.API.Respository.Interfaces;

namespace MyHero.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HeroController: ControllerBase
{
    private readonly IHeroRepository _heroRepository;
    
    public HeroController(IHeroRepository heroRepository)
    {
        _heroRepository = heroRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var heroes = await _heroRepository.GetAllAsync();
        return Ok(heroes);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var hero = await _heroRepository.GetByIdAsync(id);
        return Ok(hero);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] MyHeroModel hero)
    {
        if (hero.Id != null)
        {
            hero.Id = null;
        }
        await _heroRepository.AddAsync(hero);
        return Ok("Hero created successfully");
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] MyHeroModel hero)
    {
        await _heroRepository.UpdateAsync(id, hero);
        return Ok("Hero updated successfully");
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _heroRepository.DeleteAsync(id);
        return Ok("Hero deleted successfully");
    }
}