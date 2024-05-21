using System.Runtime.Versioning;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;

namespace backend_famLogitech_aw.Farms.Domain.Model.Aggregates;

public class Farm
{
    public int Id { get; private set; }
    public string FarmName { get; private set; }
    public string Location { get; private set; }
    public string Type { get; private set; }
    public string Infrastructure { get; private set; }
    public string Certificate { get; private set; }
    public string Product { get; private set; }

    protected Farm()
    {
        this.FarmName = string.Empty;
        this.Location = string.Empty;
        this.Type = string.Empty;
        this.Infrastructure = string.Empty;
        this.Certificate = string.Empty;
        this.Product = string.Empty;
    }

    public Farm(CreateFarmCommand command)
    {
        this.FarmName = command.FarmName;
        this.Location = command.Location;
        this.Type = command.Type;
        this.Infrastructure = command.Infrastructure;
        this.Certificate = command.Certificate;
        this.Product = command.Product;
    }
    
}