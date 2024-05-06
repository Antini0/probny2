using probny.Models;

namespace probny.Repositories;

public interface IAnimalsRepository
{
    Task<Animal> GetAnimal(int id);
}