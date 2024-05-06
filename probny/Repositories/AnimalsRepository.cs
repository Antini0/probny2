using System.Data.SqlClient;
using probny.Models;

namespace probny.Repositories;

public class AnimalsRepository : IAnimalsRepository
{
    private readonly IConfiguration _configuration;

    public AnimalsRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public async Task<Animal> GetAnimal(int id)
    {
        var query = @"SELECT       
                                         Animal.ID as AnimalID,
                                         Animal.Name as AnimalName,
                                         Type,
                                         AdmissionDate,
                                         Owner.ID as OwnerID,
                                         FirstName,   
                                         LastName,
                                         Date,
                                         [Procedure].Name as ProcedureName,
                                         Description
                      FROM Animal
                      JOIN Owner ON Owner.ID = Animal.Owner_ID
                      JOIN Procedure_Animal ON Procedure_Animal.Animal_ID = Animal.ID
                      JOIN [Procedure] ON [Procedure].ID = Procedure_Animal.Procedure_ID
                      WHERE Animal.ID = @ID";
        
        await using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Default"));
        await using SqlCommand command = new SqlCommand();
    }
}