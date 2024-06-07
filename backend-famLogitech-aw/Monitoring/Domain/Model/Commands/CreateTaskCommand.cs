namespace backend_famLogitech_aw.Monitoring.Domain.Model.Commands;

public record CreateTaskCommand(int Id, int CollaboratorId, int FarmerId, string Description);