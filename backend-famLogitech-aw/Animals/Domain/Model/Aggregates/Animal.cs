using backend_famLogitech_aw.Animals.Domain.Model.Commands;

namespace backend_famLogitech_aw.Animals.Domain.Model.Aggregates;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Location { get; set; }
    public string HealthState { get; set; }
    public int ShedId { get; set; }
    
    protected Animal()
    {
        this.Name = string.Empty;
        this.Age = 0;
        this.Location = string.Empty;
        this.HealthState = string.Empty;
    }
    
    public Animal(CreateAnimalCommand command)
    {
        this.Name = command.Name;
        this.Age = command.Age;
        this.Location = command.Location;
        this.HealthState = command.HealthState;
    }
   
    
    public void Update(UpdateAnimalCommand command)
    {
        this.Name = command.Name;
        this.Age = command.Age;
        this.Location = command.Location;
        this.HealthState = command.HealthState;
        this.ShedId = command.ShedId;
    }
    
    public void Delete(DeleteAnimalCommand command)
    {
        this.Name = string.Empty;
        this.Age = 0;
        this.Location = string.Empty;
        this.HealthState = string.Empty;
        this.ShedId = 0;
    }
    
    public void Read(ReadAnimalCommand command)
    {
        this.Name = command.Name;
        this.Age = command.Age;
        this.Location = command.Location;
        this.HealthState = command.HealthState;
        this.ShedId = command.ShedId;
    }
    
    
}