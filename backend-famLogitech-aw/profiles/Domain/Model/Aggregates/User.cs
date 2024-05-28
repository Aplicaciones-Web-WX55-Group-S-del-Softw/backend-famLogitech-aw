using backend_famLogitech_aw.profiles.Domain.Model.Commands;

namespace backend_famLogitech_aw.profiles.Domain.Model.Aggregates;

public class User
{
    public int Id { get; private set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    protected User()
    {
        this.Id = 0;
        this.Email = "";
        this.Password= "";

    }
    public User(CreateUserCommand command)
    {
        this.Id = command.Id;
        this.Email = command.Email;
        this.Password = command.Password;
    }}