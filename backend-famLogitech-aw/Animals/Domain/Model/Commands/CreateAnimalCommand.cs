namespace backend_famLogitech_aw.Animals.Domain.Model.Commands;

public record CreateAnimalCommand(int Id, string Name, string Age, string Location, string HealthState, int ShedId);