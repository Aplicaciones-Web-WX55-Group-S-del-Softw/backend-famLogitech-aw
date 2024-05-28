namespace backend_famLogitech_aw.Crops.Domain.Model.Commands;

public record ReadCropCommand(int Id, string Type, string PlantingDate, int Quantity, int ShedId);