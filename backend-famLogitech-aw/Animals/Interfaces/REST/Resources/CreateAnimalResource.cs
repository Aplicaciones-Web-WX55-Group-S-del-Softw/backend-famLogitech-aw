namespace backend_famLogitech_aw.Animals.Interfaces.Resources;

public record CreateAnimalResource(int Id, string Name, string Age, string Location, string HealthState, int ShedId);