namespace backend_famLogitech_aw.profiles.Domain.Model.Commands;

public record CreateUserCommand(int Id, string Email,
string Password);