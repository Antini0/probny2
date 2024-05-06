using probny.Models;

namespace probny.Repositories;

public interface IAnimalsRepository
{
    Task<bool> DoesAnimalExist(int id);
    Task<bool> DoesOwnerExist(int id);
    Task<bool> DoesProcedureExist(int id);
    Task<Animal> GetAnimal(int id);
    
    // Version with implicit transaction
    Task AddNewAnimalWithProcedures(NewAnimalWithProcedures newAnimalWithProcedures);
    
    // Version with transaction scope
    Task<int> AddAnimal(NewAnimal animal);
    Task AddProcedureAnimal(int animalId, ProcedureWithDate procedure);
}