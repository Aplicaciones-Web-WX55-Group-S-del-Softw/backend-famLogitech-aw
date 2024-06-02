namespace backend_famLogitech_aw.Animals.Interfaces.Resources;

public record ReadAnimalResource(int Id, string Name, int Age, string Location, string HealthState, int ShedId);