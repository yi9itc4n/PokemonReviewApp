using PokemonReviewApp.Models;

namespace PokemonReviewApp.Services.SuperHeroService;

public class SuperHeroService: ISuperHeroService
{
    private static List<SuperHero> superHeroes = new List<SuperHero>
    {
        new SuperHero
        {
            Id = 1,
            Name = "Batman",
            FirstName = "Bruce",
            LastName = "Wayne",
            Place = "Gotham City"
        },
        new SuperHero
        {
            Id = 2,
            Name = "Superman",
            FirstName = "Clark",
            LastName = "Kent",
            Place = "Metropolis"
        },
        new SuperHero
        {
            Id = 3,
            Name = "Spiderman",
            FirstName = "Peter",
            LastName = "Parker",
            Place = "New York"
        }
    };
    
    public List<SuperHero> GetAllHeroes()
    {
        return superHeroes;
    }

    public SuperHero? GetHeroById(int id)
    {
        var hero = superHeroes.FirstOrDefault(h => h.Id == id);
        if (hero == null)
        {
            return null;
        }
        return hero;
    }

    public List<SuperHero> AddHero(SuperHero hero)
    {
        superHeroes.Add(hero);
        return superHeroes;
    }

    public List<SuperHero>? UpdateHero(int id, SuperHero hero)
    {
        
        var heroToUpdate = superHeroes.FirstOrDefault(h => h.Id == id);
        if (heroToUpdate == null)
        {
            return null;
        }
        heroToUpdate.Name = hero.Name;
        heroToUpdate.FirstName = hero.FirstName;
        heroToUpdate.LastName = hero.LastName;
        heroToUpdate.Place = hero.Place;
        return superHeroes;
    }

    public List<SuperHero>? DeleteHero(int id)
    {
        var heroToDelete = superHeroes.FirstOrDefault(h => h.Id == id);
        if (heroToDelete == null)
        {
            return null;
        }
        superHeroes.Remove(heroToDelete);
        return superHeroes;
    }
}