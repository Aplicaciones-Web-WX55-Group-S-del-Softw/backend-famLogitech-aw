namespace backend_famLogitech_aw.Crops.Domain.Model.Commands;

public record UpdateCropCommand(int Id, string Type, string PlantingDate, int Quantity, int ShedId);