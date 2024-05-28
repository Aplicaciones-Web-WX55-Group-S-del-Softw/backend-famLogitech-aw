namespace backend_famLogitech_aw.Animals.Domain.Model.Commands;

public record UpdateAnimalCommand(int Id, string Name, string Age, string Location, string HealthState, int ShedId);