namespace backend_famLogitech_aw.Monitoring.Domain.Model.Commands;

public record UpdateTaskCommand(int CollaboratorId, int FarmerId, string Description);