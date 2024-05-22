namespace backend_famLogitech_aw.Farms.Domain.Model.Commands;

public record class UpdateFarmCommand(int resourceId, string resourceFarmName, string resourceLocation, string resourceType, string resourceInfrastructure, string resourceCertificate, string resourceProduct)
{
    public int Id { get; private set; }
    public string FarmName { get; set; }
    public string Location { get; set; }
    public string Type { get; set; }
    public string Infrastructure { get; set; } 
    public string Certificate { get; set; }
    public string Product { get; set; }

}