namespace backend_famLogitech_aw.Farms.Interfaces.REST.Resources;

public record CreateFarmResource(int Id,string FarmName, string Location, string Type, string Infrastructure, string Certificate, string Product);