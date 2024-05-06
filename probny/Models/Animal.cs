namespace probny.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public DateTime AdmissionDate { get; set; }
    public Owner Owner { get; set; } = null!;
    public List<Procedure> Procedures { get; set; } = null!;
}