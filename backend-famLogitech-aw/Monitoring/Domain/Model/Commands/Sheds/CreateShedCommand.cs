namespace backend_famLogitech_aw.Farms.Domain.Model.Commands;

public record CreateShedCommand(int Id, int FarmId, string Location, string Type);
