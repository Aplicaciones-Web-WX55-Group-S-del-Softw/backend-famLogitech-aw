namespace backend_famLogitech_aw.Farms.Interfaces.REST.Resources;
//parece un struct 
public record FarmResource(int Id,string FarmName, string Location, string Type, string Infrastructure, string Certificate, string Product);