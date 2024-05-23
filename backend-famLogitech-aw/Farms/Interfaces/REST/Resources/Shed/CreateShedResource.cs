namespace backend_famLogitech_aw.Farms.Interfaces.REST.Resources.Shed;

public record CreateShedResource(int Id, int FarmId, string Location, string Type);